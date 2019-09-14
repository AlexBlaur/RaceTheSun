using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class TreeGenerator : MonoBehaviour
    {
        public List<GameObject> Trees; 
        protected List<GameObject> TreesMassive; 
        public long TreesCount;


        public float MinWidth;
        public float MaxWidth;
        public float MinHeight;
        public float MaxHeight;
        public float ZCoordinate;

        private void Start()
        {
            TreesMassive = new List<GameObject>();
            GenerateTrees();
        }

        public void GenerateTrees()
        {
            while (TreesMassive.Count < TreesCount)
            {
                GameObject tree = Instantiate(Trees[Random.Range(0, Trees.Count)]);
                Vector3 position = new Vector3(Random.Range(MinWidth, MaxWidth), ZCoordinate, Random.Range(MinHeight, MaxHeight));
                tree.transform.position = position;
                TreesMassive.Add(tree);
            }
        }
    }
}