using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

struct Input
{
    public string InputName;
    public string InputSignal;
}

struct Output
{
    public string OutputName;
    public string Type;
    public string InputName1;
    public string InputName2;
}

class Solution
{
    static void Main(string[] args)
    {
        List<Input> inputList = new List<Input>();
        List<Output> outputList = new List<Output>();
        List<string> finalList = new List<string>();

        string[] inputs;
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string inputName = inputs[0];
            string inputSignal = inputs[1];
            Input input = new Input();
            input.InputName = inputName;
            input.InputSignal = inputSignal;
            inputList.Add(input);
        }
        for (int i = 0; i < m; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string outputName = inputs[0];
            string type = inputs[1];
            string inputName1 = inputs[2];
            string inputName2 = inputs[3];
            Output output = new Output();
            output.OutputName = outputName;
            output.Type = type;
            output.InputName1 = inputName1;
            output.InputName2 = inputName2;
            outputList.Add(output);
        }
        for (int i = 0; i < m; i++)
        {
            string i1 = inputList.Find(x => x.InputName == outputList[i].InputName1).InputSignal;
            string i2 = inputList.Find(x => x.InputName == outputList[i].InputName2).InputSignal;
            string output = "";
            if (outputList[i].Type == "AND")
            {
                output = outputList[i].OutputName + " ";
                for (int j = 0; j < i1.Length; j++)
                {

                    if (i1[j] == '_' || i2[j] == '_')
                    {
                        output += '_';
                    }
                    else
                    {
                        output += '-';
                    }

                }
                finalList.Add(output);
            }
            else if (outputList[i].Type == "OR")
            {
                output = outputList[i].OutputName + " ";
                for (int j = 0; j < i1.Length; j++)
                {
                    if (i1[j] == '-' || i2[j] == '-')
                    {
                        output += '-';
                    }
                    else
                    {
                        output += '_';
                    }
                }
                finalList.Add(output);
            }
            else if (outputList[i].Type == "XOR")
            {
                output = outputList[i].OutputName + " ";
                for (int j = 0; j < i1.Length; j++)
                {
                    if ((i1[j] == '-' && i2[j] == '_') || (i1[j] == '_' && i2[j] == '-'))
                    {
                        output += '-';
                    }
                    else
                    {
                        output += '_';
                    }
                }
                finalList.Add(output);
            }
            else if (outputList[i].Type == "NAND")
            {
                output = outputList[i].OutputName + " ";
                for (int j = 0; j < i1.Length; j++)
                {
                    if (i1[j] == '_' || i2[j] == '_')
                    {
                        output += '-';
                    }
                    else
                    {
                        output += '_';
                    }
                }
                finalList.Add(output);
            }
            else if (outputList[i].Type == "NOR")
            {
                output = outputList[i].OutputName + " ";
                for (int j = 0; j < i1.Length; j++)
                {
                    if (!(i1[j] == '-' || i2[j] == '-'))
                    {
                        output += '-';
                    }
                    else
                    {
                        output += '_';
                    }
                }
                finalList.Add(output);
            }
            else if (outputList[i].Type == "NXOR")
            {
                output = outputList[i].OutputName + " ";
                for (int j = 0; j < i1.Length; j++)
                {
                    if (!((i1[j] == '-' && i2[j] == '_') || (i1[j] == '_' && i2[j] == '-')))
                    {
                        output += '-';
                    }
                    else
                    {
                        output += '_';
                    }
                }
                finalList.Add(output);
            }
        }
        foreach (string s in finalList)
        {
            Console.WriteLine(s);
        }

    }
}