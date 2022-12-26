using System;
using System.Collections.Generic;

namespace Bees_algorithm
{
    public class Bee
    {
        private double[] _position; 
        private double _minPosition, _maxPosition;
        private static Random rand = new Random();
        public double[] Position => _position;
        public double Fitness { get; set; }

        public Bee(double minX, double maxX)
        {
            _position = new double[2];
            _position[0] = rand.NextDouble() * (maxX - minX) + minX;
            _position[1] = rand.NextDouble() * (maxX - minX) + minX;
            _minPosition = minX;
            _maxPosition = maxX;
        }

        public void CalcFitness(Func<double, double, string, double> fitnessFunc, string strFitnessFunc) => Fitness = fitnessFunc(_position[0], _position[1], strFitnessFunc);

        public bool OtherPath(List<double[]> elitePlaces, double[] _neighborhood)
        {
            if (elitePlaces.Count == 0) return true;

            foreach(var place in elitePlaces)
            {
                for(int i = 0; i < place.Length; i++)
                {
                    if (Math.Abs(_position[i] - place[i]) > _neighborhood[i]) return true;
                }
            }
            return false;
        }

        public void GoToRandom()
        {
            _position[0] = rand.NextDouble() * (_maxPosition - _minPosition) + _minPosition;
            _position[1] = rand.NextDouble() * (_maxPosition - _minPosition) + _minPosition;
        }

        public void GoTo(double[] place)
        {
           for(int i = 0; i < place.Length; i++)
            {
                int val = (int)Math.Abs(place[i]);
                _position[i] += rand.Next(-val,val);
            }

            CheckPosition();
        }

        private void CheckPosition()
        {
            for(int i = 0; i < Position.Length; i++)
            {
                if (_position[i] < _minPosition)
                    _position[i] = _minPosition;
                else if (_position[i] > _maxPosition)
                    _position[i] = _maxPosition;
            }
        }
    }
}
