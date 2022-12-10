using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bees_algorithm
{
    public class Hive
    {
        private int _scoutsNum;
        private int _eliteBeeNum;
        private int _workersBeeNum;
        private int _numElitePlaces;
        private int _numGoodPlaces;
        private int _numIterationAlg;
        private double _bestFitness;
        private double[] _neighborhood, _bestPlace;
        private string _strFitnessFunc;
        private List<Bee> _swarm;
        private List<double[]> _elitePlaces;
        private List<double[]> _goodPlaces;


        public Hive(int scoutsNum, int eliteBeeNum, int workersBeeNum, int numElitePlaces,
            int numGoodPlaces, double[] neighborhood, double minX, double maxX, int numIterationAlg, string strFitnessFunc)
        {
            _scoutsNum = scoutsNum;
            _eliteBeeNum = eliteBeeNum;
            _workersBeeNum = workersBeeNum;
            _numElitePlaces = numElitePlaces;
            _numGoodPlaces = numGoodPlaces;
            _numIterationAlg = numIterationAlg;
            _neighborhood = neighborhood;
            _strFitnessFunc = strFitnessFunc;
            InitializeLists(minX, maxX);
        }

        public void StartHiveAlg()
        {
            RankPlaces();
            int i = 0, counter = 0;
            double prevBestFitness = _swarm[0].Fitness;
            while(i < _numIterationAlg && counter < 50) 
            { 
                SelectPlaces();
                SendBeesToPlaces();
                RankPlaces();
                if (prevBestFitness == _bestFitness) counter++;
                else
                {
                    prevBestFitness = _bestFitness;
                    counter = 0;
                }
                ClearOldEliteAndGoodPlaces();
                i++;
            }
        }

        public (double bestFitness, double[] bestPlace) GetBest() => (_bestFitness, _bestPlace);

        private void RankPlaces()
        {
            for (int i = 0; i < _swarm.Count; i++)
                _swarm[i].CalcFitness(MathParserSpace.MathParser.calculate, _strFitnessFunc);

            _swarm = _swarm.OrderBy(bee => bee.Fitness).ToList();
            SetBestResult();
        }

        private void SelectPlaces()
        {
            _elitePlaces.Add(_swarm[0].Position);
            int idxBee = 1;
            SelectElitePlaces(ref idxBee);
            SelectGoodPlaces(idxBee);
        }

        private void SelectElitePlaces(ref int idxBee)
        {
            for (; idxBee < _swarm.Count; idxBee++)
            {
                if (_swarm[idxBee].OtherPath(_elitePlaces, _neighborhood))
                    _elitePlaces.Add(_swarm[idxBee].Position);
                if (_elitePlaces.Count == _numElitePlaces) break;
            }
        }

        private void SelectGoodPlaces(int idxBee)
        {
            for (; idxBee < _swarm.Count; idxBee++)
            {
                if (_swarm[idxBee].OtherPath(_elitePlaces, _neighborhood) && _swarm[idxBee].OtherPath(_goodPlaces, _neighborhood))
                    _goodPlaces.Add(_swarm[idxBee].Position);
                if (_goodPlaces.Count == _numGoodPlaces) break;
            }
        }

        private void ClearOldEliteAndGoodPlaces()
        {
            _elitePlaces.Clear();
            _goodPlaces.Clear();
        }

        private void SendBeesToPlaces()
        {
            int idxBee = 1;
            foreach (var elitePlace in _elitePlaces)
                idxBee = SendBee(elitePlace, idxBee, _eliteBeeNum);

            foreach (var goodPlace in _goodPlaces)
                idxBee = SendBee(goodPlace, idxBee, _workersBeeNum);

            for (; idxBee < _swarm.Count; idxBee++)  
                _swarm[idxBee].GoToRandom();
        }
        private int SendBee(double[] elitePlace, int idxBee, int eliteBeeNum)
        {
            int count = 0;
            while (count < eliteBeeNum)
            {
                _swarm[idxBee++].GoTo(elitePlace);
                count++;
            }
            return idxBee;
        }

        private void SetBestResult()
        {
            _bestFitness = _swarm[0].Fitness;
            _bestPlace = _swarm[0].Position;
        }       

        private void InitializeLists(double minX, double maxX)
        {
            _swarm = new List<Bee>();
            _elitePlaces = new List<double[]>();
            _goodPlaces = new List<double[]>();
            int beeCount = _scoutsNum + _workersBeeNum * _numGoodPlaces + _eliteBeeNum * _numElitePlaces;
            for (int i = 0; i < beeCount; i++)
            {
                _swarm.Add(new Bee(minX, maxX));
            }
        }
    }
}
