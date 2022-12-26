using System.Collections.Generic;
using System.Linq;

namespace Bees_algorithm
{
    public class BeeСolony
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


        public BeeСolony(int scoutsNum, int eliteBeeNum, int workersBeeNum, int numElitePlaces,
            int numGoodPlaces, double[] neighborhood, double minX, double maxX, int numIterationAlg, string strFitnessFunc)
        {
            InitializeParams(scoutsNum, eliteBeeNum, workersBeeNum, numElitePlaces, numGoodPlaces, neighborhood, numIterationAlg, strFitnessFunc);
            InitializeLists(minX, maxX);
        }

        private void InitializeParams(int scoutsNum, int eliteBeeNum, int workersBeeNum, int numElitePlaces, int numGoodPlaces, double[] neighborhood, int numIterationAlg, string strFitnessFunc)
        {
            _scoutsNum = scoutsNum;
            _eliteBeeNum = eliteBeeNum;
            _workersBeeNum = workersBeeNum;
            _numElitePlaces = numElitePlaces;
            _numGoodPlaces = numGoodPlaces;
            _numIterationAlg = numIterationAlg;
            _neighborhood = neighborhood;
            _strFitnessFunc = strFitnessFunc;
        }

        public void Run()
        {
            for (int k = 0; k < _swarm.Count; k++)
                _swarm[k].CalcFitness(MathParserSpace.MathParser.calculate, _strFitnessFunc);

            _swarm = _swarm.OrderBy(bee => bee.Fitness).ToList();
            int i = 0, counter = 0;
            double prevBestFitness = _swarm[0].Fitness;
            while(i < _numIterationAlg && counter < 30) 
            {
                _elitePlaces.Add(_swarm[0].Position);
                int idxBee = 1;
                for (; idxBee < _swarm.Count; idxBee++)
                {
                    if (_swarm[idxBee].OtherPath(_elitePlaces, _neighborhood))
                        _elitePlaces.Add(_swarm[idxBee].Position);
                    if (_elitePlaces.Count == _numElitePlaces) break;
                }

                for (; idxBee < _swarm.Count; idxBee++)
                {
                    if (_swarm[idxBee].OtherPath(_elitePlaces, _neighborhood) && _swarm[idxBee].OtherPath(_goodPlaces, _neighborhood))
                        _goodPlaces.Add(_swarm[idxBee].Position);
                    if (_goodPlaces.Count == _numGoodPlaces) break;
                }

                SendBeesToPlaces();

                for (int k = 0; k < _swarm.Count; k++)
                    _swarm[k].CalcFitness(MathParserSpace.MathParser.calculate, _strFitnessFunc);

                _swarm = _swarm.OrderBy(bee => bee.Fitness).ToList();

                _bestFitness = _swarm[0].Fitness;
                _bestPlace = _swarm[0].Position;
                if (prevBestFitness == _bestFitness) counter++;
                else
                {
                    prevBestFitness = _bestFitness;
                    counter = 0;
                }

                _elitePlaces.Clear();
                _goodPlaces.Clear();
                i++;
            }
        }

        public (double, double[]) GetBest() => (_bestFitness, _bestPlace);


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
        private int SendBee(double[] place, int idxBee, int eliteBeeNum)
        {
            int count = 0;
            while (count < eliteBeeNum)
            {
                _swarm[idxBee++].GoTo(place);
                count++;
            }
            return idxBee;
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
