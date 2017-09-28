using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnDForDummies
{
    class ResearchLevel
    {
        public int Materials;
        public int Engineering;
        public int Plasma;
        public int Power;
        public int Bluespace;
        public int Biological;
        public int Combat;
        public int EMP;
        public int Data;
        public int Illegal;
        public int Abductor;

        public ResearchLevel(string line)
        {
            string[] researchLevels = line.Split(';');
            foreach(string researchLevel in researchLevels)
            {
                string[] level = researchLevel.Split('=');
                ResearchType type = (ResearchType)Convert.ToInt32(level[0]);
                if (type == ResearchType.Materials)
                    Materials = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Engineering)
                    Engineering = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Plasma)
                    Plasma = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Power)
                    Power = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Bluespace)
                    Bluespace = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Biological)
                    Biological = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Combat)
                    Combat = Convert.ToInt32(level[1]);
                else if (type == ResearchType.EMP)
                    EMP = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Data)
                    Data = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Illegal)
                    Illegal = Convert.ToInt32(level[1]);
                else if (type == ResearchType.Abductor)
                    Abductor = Convert.ToInt32(level[1]);
            }
        }
    }

    public enum ResearchType
    {
        Empty, //0
        Materials, //1
        Engineering, //2
        Plasma, //3
        Power, //4
        Bluespace, //5
        Biological, //6
        Combat, //7
        EMP, //8
        Data, //9
        Illegal, //10
        Abductor //11
    }
}
