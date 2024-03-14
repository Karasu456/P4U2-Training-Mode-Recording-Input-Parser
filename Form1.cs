using System.Windows.Forms;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Text;
using System.Windows.Forms.VisualStyles;

namespace P4U2_Training_Mode_Recording_Input_Parsing_Tool
{
    public partial class Form1 : Form
    {
        //Save.dat File Pathing
        public static string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public string saveFilePath = appDataFolder + "\\P4U2\\Save\\save.dat";
        public string defaultOutputPath = appDataFolder + "\\P4U2\\Save\\Recordings";
        //private bool failedInputCheck = false;

        public Form1()
        {
            InitializeComponent();
        }
        /*private void NoDirectionAndNoOuputSelected()//Returns Form if No Direction and Output are selected 
        {
            if (!(checkboxRecordingLeft.Checked) && !(checkboxRecordingRight.Checked))
            {
                if (!(checkboxOutputEKEY.Checked) && !(checkboxOutputKEY.Checked))
                {
                    Popup popup = new Popup();
                    popup.StartPosition = FormStartPosition.CenterParent;
                    popup.richTextBox1.Text = "Please select 1 Recording Direction and 1 Output Mode before pressing Parse Input Data.";
                    DialogResult dialogresult = popup.ShowDialog();
                    if (dialogresult == DialogResult.OK)
                    {
                        Console.WriteLine("Please select 1 Recording Direction and 1 Output Mode before pressing Parse Input Data.");
                    }
                    popup.Dispose();
                    failedInputCheck = true;
                    return;
                }
            }
        }
        private void DirectionPresentAndNoOutputSelected()//Returns Form if No Direction and Output are selected 
        {
            if ((checkboxRecordingLeft.Checked) || (checkboxRecordingRight.Checked))
            {
                if (!(checkboxOutputEKEY.Checked) && !(checkboxOutputKEY.Checked))
                {
                    Popup popup = new Popup();
                    popup.StartPosition = FormStartPosition.CenterParent;
                    popup.richTextBox1.Text = "Please select 1 Output Mode before pressing Parse Input Data.";
                    DialogResult dialogresult = popup.ShowDialog();
                    if (dialogresult == DialogResult.OK)
                    {
                        Console.WriteLine("Please select 1 Output Mode before pressing Parse Input Data.");
                    }
                    popup.Dispose();
                    failedInputCheck = true;
                    return;
                }
            }
        }
        private void OutputPresentAndMultipleDirectionsPresent()//Returns Form if No Direction and Output are selected 
        {
            if ((checkboxOutputEKEY.Checked) || (checkboxOutputKEY.Checked))
            {
                if (!(checkboxRecordingLeft.Checked) && !(checkboxRecordingRight.Checked))
                {
                    Popup popup = new Popup();
                    popup.StartPosition = FormStartPosition.CenterParent;
                    popup.richTextBox1.Text = "Please select 1 Recording Direction before pressing Parse Input Data.";
                    DialogResult dialogresult = popup.ShowDialog();
                    if (dialogresult == DialogResult.OK)
                    {
                        Console.WriteLine("Please select 1 Recording Direction before pressing Parse Input Data.");
                    }
                    popup.Dispose();
                    failedInputCheck = true;
                    return;
                }
                if (checkboxRecordingLeft.Checked && checkboxRecordingRight.Checked)
                {
                    Popup popup = new Popup();
                    popup.StartPosition = FormStartPosition.CenterParent;
                    popup.richTextBox1.Text = "Please select 1 Recording Direction before pressing Parse Input Data.";
                    DialogResult dialogresult = popup.ShowDialog();
                    if (dialogresult == DialogResult.OK)
                    {
                        Console.WriteLine("Please select 1 Recording Direction before pressing Parse Input Data.");
                    }
                    popup.Dispose();
                    failedInputCheck = true;
                    return;
                }
            }
        }

        private void DirectionPresentAndMultipleOutputsPresent()//Returns Form if No Direction and Output are selected 
        {
            if (checkboxRecordingLeft.Checked || checkboxRecordingRight.Checked)
            {
                if ((checkboxOutputEKEY.Checked) && (checkboxOutputKEY.Checked))
                {
                    Popup popup = new Popup();
                    popup.StartPosition = FormStartPosition.CenterParent;
                    popup.richTextBox1.Text = "Please select 1 Output Mode before pressing Parse Input Data.";
                    DialogResult dialogresult = popup.ShowDialog();
                    if (dialogresult == DialogResult.OK)
                    {
                        Console.WriteLine("Please select 1 Output Mode before pressing Parse Input Data.");
                    }
                    popup.Dispose();
                    failedInputCheck = true;
                    return;
                }
            }
        }*/

        private static List<string>[] SortRecordings(string filePath) //Organizes Recording Data to be able to be parsed 
        {
            List<string>[] a = new List<string>[5];
            try
            {
                //Read Save.dat from User's Roaming Data
                BinaryReader br = new BinaryReader(new MemoryStream(File.ReadAllBytes(filePath)));
                Console.WriteLine("Save data opened.");
                //Offsets used for Sorting Hex Data
                int initialRecordingOffset = 0x000C5D28;
                //int finalRecordingOffset = 0x000CDC94;
                int recordingLength = 0x00007F6C;
                //Set the Binary Reader's Position and Record from Initial Offset to Final Offset
                br.BaseStream.Position = initialRecordingOffset;
                byte[] array = br.ReadBytes(recordingLength);
                //Convert Save.dat's bytes to Hex and compile data into list
                string hexData = Convert.ToHexString(array);
                string tmp = "";
                List<string> hexDataList = new List<string>();
                List<int> positionFFFF = new List<int>();
                for (int i = 0; i < hexData.Length; i += 4)
                {
                    tmp = hexData.Substring(i, 4);
                    hexDataList.Add(tmp);
                }

                for (int i = 0; i < hexDataList.Count; i++)
                {
                    if (hexDataList[i].Equals("FFFF"))
                    {
                        positionFFFF.Add(i);
                        i += 3;
                    }
                }
                //Individual recordings' data compilation into lists
                List<string> recording1 = new List<string>();
                string divider = "FFFF";
                tmp = "";
                for (int i = 4; i < positionFFFF[1]; i++)
                {
                    if (hexDataList[i].Equals(divider))
                    {
                        break;
                    }
                    if (hexDataList[i].Equals("0000") && i > positionFFFF[0] + 9)
                    {
                        break;
                    }
                    tmp = hexDataList[i];
                    recording1.Add(tmp);
                }
                List<string> recording2 = new List<string>();
                for (int i = positionFFFF[1] + 4; i < positionFFFF[2]; i++)
                {
                    if (hexDataList[i].Equals(divider))
                    {
                        break;
                    }
                    if (hexDataList[i].Equals("0000") && i > positionFFFF[1] + 9)
                    {
                        break;
                    }
                    tmp = hexDataList[i];
                    recording2.Add(tmp);
                }
                List<string> recording3 = new List<string>();
                for (int i = positionFFFF[2] + 4; i < positionFFFF[3]; i++)
                {
                    if (hexDataList[i].Equals(divider))
                    {
                        break;
                    }
                    if (hexDataList[i].Equals("0000") && i > positionFFFF[2] + 9)
                    {
                        break;
                    }
                    tmp = hexDataList[i];
                    recording3.Add(tmp);
                }
                List<string> recording4 = new List<string>();
                for (int i = positionFFFF[3] + 4; i < positionFFFF[4]; i++)
                {
                    if (hexDataList[i].Equals(divider))
                    {
                        break;
                    }
                    if (hexDataList[i].Equals("0000") && i > positionFFFF[3] + 9)
                    {
                        break;
                    }
                    tmp = hexDataList[i];
                    recording4.Add(tmp);
                }
                List<string> recording5 = new List<string>();
                for (int i = positionFFFF[4] + 4; i < positionFFFF[4] + 2400; i++)
                {
                    if (hexDataList[i].Equals(divider))
                    {
                        break;
                    }
                    if (hexDataList[i].Equals("0000") && i > positionFFFF[4] + 9)
                    {
                        break;
                    }
                    tmp = hexDataList[i];
                    recording5.Add(tmp);
                }
                Console.WriteLine("Recordings Sorted.");
                a[0] = recording1;
                a[1] = recording2;
                a[2] = recording3;
                a[3] = recording4;
                a[4] = recording5;
                return a;
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred. Please try again!");
#pragma warning disable CS8603 // Possible null reference return.
                return null;
#pragma warning restore CS8603 // Possible null reference return.
            }
        }
        private static List<string> ConstructInputLog(List<string> recordingData, bool[] directionSettings) //Constructs Input Log from Sorted Recording Data 
        {
            List<string> constructedInputLog = new List<string>();
            //bool directionDoesNotNeedAdjustment = false;
            string currentAttack, currentNumpadKey;
            int currentFrame = 0, inputFrameCount = 1;
            string tmpInput;

            //Boolean is iniitally set by the direction settings' Initial Facing Direction
            bool directionDoesNotNeedAdjustment = directionSettings[0];

            //See Initial Facing Direction and Adjust Ouput Per Output Facing Direction

            //Initial Facing Right & Output Facing Right
            if (directionSettings[0] && directionSettings[0])
            {
                directionDoesNotNeedAdjustment = true;
            }

            //Initial Facing Left & Output Facing Right
            if (directionSettings[0] == false && directionSettings[1])
            {
                directionDoesNotNeedAdjustment = false;
            }

            //Initially Facing Right & Output Facing Left
            if (directionSettings[0] && directionSettings[1] == false)
            {
                directionDoesNotNeedAdjustment = false;
            }

            //Initially Facing Left & Output Facing Left
            if (directionSettings[0] == false && !directionSettings[1] == false)
            {
                directionDoesNotNeedAdjustment = true;
            }

            //Determine if player is initially facing Right or Left
            //Terrible Logic for Determining This Lmfao
            /*for (int i = 0; i < 60; i++)
            {
                if (recordingData[i].Contains("06"))
                {
                    directionDoesNotNeedAdjustment = true;
                    break;
                }
            }*/
            if (directionDoesNotNeedAdjustment == true) //Facing Right?
            {
                //constructedInputLog.Add("Naturally Facing Right. *Manually overlook to see if inputs mapped are correct*");
                //constructedInputLog.Add("---------------------------");
                //constructedInputLog.Add("-KEY-");
                for (int i = 6; i < recordingData.Count; i++)
                {
                    currentAttack = recordingData[i].Substring(0, 1);
                    currentNumpadKey = recordingData[i].Substring(1, 1);
                    tmpInput = recordingData[i].Substring(0, 2);

                    if (i < recordingData.Count - 1)
                    {
                        if ((tmpInput + "00").Equals(recordingData[i + 1])) //Check if the next input is repeated
                        {
                            inputFrameCount++;
                            continue;
                        }
                    }
                    else if (i == recordingData.Count)
                    {
                        inputFrameCount++;
                    }
                    switch (currentAttack)
                    {
                        //Single Buttons
                        case "1": //A?
                            currentAttack = "A";
                            break;
                        case "2": //B?
                            currentAttack = "B";
                            break;
                        case "4": //C?
                            currentAttack = "C";
                            break;
                        case "8": //D?
                            currentAttack = "D";
                            break;

                        //Two-Buttons
                        case "3": //AoA?
                            currentAttack = "AB";
                            break;
                        case "5": //Roll or Airturn?
                            currentAttack = "AC";
                            break;
                        case "6":
                            currentAttack = "BC";
                            break;
                        case "9":
                            currentAttack = "AD";
                            break;
                        case "A": //Reversal?
                            currentAttack = "BD";
                            break;
                        case "C": //Throw?
                            currentAttack = "CD";
                            break;

                        //Three-Buttons
                        case "7": //OMC?
                            currentAttack = "ABC";
                            break;
                        case "B": //Unused
                            currentAttack = "ABD";
                            break;
                        case "D": //Burst or OMB?
                            currentAttack = "ACD";
                            break;
                        case "E": //Unused
                            currentAttack = "BCD";
                            break;

                        //Four-Buttons
                        case "F": //Unused
                            currentAttack = "ABCD";
                            break;

                        //Zero-Buttons
                        case "0": //Empty Input?
                            currentAttack = "-";
                            break;
                    }
                    //Console.WriteLine(currentNumpadKey + "\t" + currentAttack + "\t" + inputFrameCount);
                    constructedInputLog.Add(currentNumpadKey + "\t" + currentAttack + "\t" + inputFrameCount); //Build String & Add to List
                    if ((tmpInput + "00").Equals(recordingData[i - 1]) && i < recordingData.Count - 1)
                    {
                        inputFrameCount = 1; //Reset Frame Count of CurrentInput
                    }
                }
            }
            else //Facing Left and Inputs Need Conversion :(
            {
                //constructedInputLog.Add("Converted from Facing Left to Right. *Manually overlook to see if inputs mapped are correct*");
                //constructedInputLog.Add("---------------------------");
                //constructedInputLog.Add("-KEY-");
                for (int i = 6; i < recordingData.Count; i++)
                {
                    currentAttack = recordingData[i].Substring(0, 1);
                    currentNumpadKey = recordingData[i].Substring(1, 1);
                    tmpInput = recordingData[i].Substring(0, 2);
                    currentFrame++;
                    if (i < recordingData.Count - 1)
                    {
                        if ((tmpInput + "00").Equals(recordingData[i + 1])) //Check if the next input is repeated
                        {
                            inputFrameCount++;
                            continue;
                        }
                    }
                    else if (i == recordingData.Count)
                    {
                        inputFrameCount++;
                    }
                    switch (currentAttack)
                    {
                        //Single Buttons
                        case "1": //A?
                            currentAttack = "A";
                            break;
                        case "2": //B?
                            currentAttack = "B";
                            break;
                        case "4": //C?
                            currentAttack = "C";
                            break;
                        case "8": //D?
                            currentAttack = "D";
                            break;

                        //Two-Buttons
                        case "3": //AoA?
                            currentAttack = "AB";
                            break;
                        case "5": //Roll or Airturn?
                            currentAttack = "AC";
                            break;
                        case "6":
                            currentAttack = "BC";
                            break;
                        case "9":
                            currentAttack = "AD";
                            break;
                        case "A": //Reversal?
                            currentAttack = "BD";
                            break;
                        case "C": //Throw?
                            currentAttack = "CD";
                            break;

                        //Three-Buttons
                        case "7": //OMC?
                            currentAttack = "ABC";
                            break;
                        case "B": //Unused
                            currentAttack = "ABD";
                            break;
                        case "D": //Burst or OMB?
                            currentAttack = "ACD";
                            break;
                        case "E": //Unused
                            currentAttack = "BCD";
                            break;

                        //Four-Buttons
                        case "F": //Unused
                            currentAttack = "ABCD";
                            break;

                        //Zero-Buttons
                        case "0": //Empty Input?
                            currentAttack = "-";
                            break;
                    }
                    switch (currentNumpadKey) //Adjust Inputs to be Facing Right
                    {
                        case "1": //Down Left?
                            currentNumpadKey = "3";
                            break;
                        case "3": //Down Right?
                            currentNumpadKey = "1";
                            break;
                        case "4": //Left?
                            currentNumpadKey = "6";
                            break;
                        case "6": //Right?
                            currentNumpadKey = "4";
                            break;
                        case "7": //Up Left?
                            currentNumpadKey = "9";
                            break;
                        case "9": //Up Right?
                            currentNumpadKey = "7";
                            break;
                    }

                    //Console.WriteLine(currentNumpadKey + "\t" + currentAttack + "\t" + inputFrameCount);
                    constructedInputLog.Add(currentNumpadKey + "\t" + currentAttack + "\t" + inputFrameCount); //Build String & Add to List
                    if ((tmpInput + "00").Equals(recordingData[i - 1]) && i < recordingData.Count - 1)
                    {
                        inputFrameCount = 1; //Reset Frame Count of CurrentInput
                    }
                }
            }

            
            //Before Returning an InputLog, Clean the Dataset per InputLogCleanup()
            return InputLogCleanup(constructedInputLog);
        }

        private static List<string> InputLogCleanup(List<string> inputList)
        {
            var cleanInputList = new List<string>();
            int pendingFrameCount = 0;            

            foreach(string key in inputList)
            {                
                string[] splitKey = key.Split('\t');
                string[] pendingKey;

                //Handle "Empty" Frame - Frames where there is no button input & the frame is held for 1 count
                if (splitKey[1].Equals("-") && splitKey[2].Equals("1") && cleanInputList.Count > 0)
                {
                    pendingKey = cleanInputList.Last().Split('\t');
                    pendingFrameCount = int.Parse(pendingKey[2]) + 1;
                    pendingKey[2] = pendingFrameCount.ToString();
                    cleanInputList.RemoveAt(cleanInputList.Count - 1);
                    
                    string newKey = string.Join("\t", pendingKey);
                    cleanInputList.Add(newKey);
                    continue;
                }
                //Handle "Single Frame" button presses
                if (splitKey[1].Contains("A") || splitKey[1].Contains("B") || splitKey[1].Contains("C") || splitKey[1].Contains("D") && cleanInputList.Count > 0)
                {
                    if (splitKey[2].Equals("1"))
                    {
                        pendingKey = cleanInputList.Last().Split('\t');
                        pendingFrameCount = int.Parse(pendingKey[2]) + 1;
                        pendingKey[2] = pendingFrameCount.ToString();
                        cleanInputList.RemoveAt(cleanInputList.Count - 1);

                        string newKey = string.Join("\t", pendingKey);
                        cleanInputList.Add(newKey);
                        continue;
                    }
                }
                //Combine Same Input frames - "5 - 20" && "5 - 34"
                if (cleanInputList.Count > 0)
                {
                    pendingKey = cleanInputList.Last().Split('\t');

                    if (splitKey[0].Equals(pendingKey[0]) && splitKey[1].Equals(pendingKey[1]))
                    {
                        pendingFrameCount = int.Parse(splitKey[2]) + int.Parse(pendingKey[2]);
                        pendingKey[2] = pendingFrameCount.ToString();
                        cleanInputList.RemoveAt(cleanInputList.Count - 1);

                        string newKey = string.Join("\t", pendingKey);
                        cleanInputList.Add(newKey);
                        continue;
                    }                    
                }
                
                cleanInputList.Add(key);
            }

            
            return cleanInputList;
        }
        
        public void DisplayAndWriteData(List<string>[] inputLogArray, bool[] outputSettings, int recordingOption)
        //Displaying Data to Form and Writing it to Txt Files 
        {
            List<string> inputLog = inputLogArray[0];
            List<string> inputLog2 = inputLogArray[1];
            List<string> inputLog3 = inputLogArray[2];
            List<string> inputLog4 = inputLogArray[3];
            List<string> inputLog5 = inputLogArray[4];

            Dictionary<int, List<string>> dictInputLogs = new()
            {
                [0] = inputLog,
                [1] = inputLog2,
                [2] = inputLog3,
                [3] = inputLog4,
                [4] = inputLog5,
            };

            /*List<string> eInputLog = enemyInputLogArray[0];
            List<string> eInputLog2 = enemyInputLogArray[1];
            List<string> eInputLog3 = enemyInputLogArray[2];
            List<string> eInputLog4 = enemyInputLogArray[3];
            List<string> eInputLog5 = enemyInputLogArray[4];*/

            bool initialFacingRight = outputSettings[0];
            bool outputFacingRight = outputSettings[1];
            bool generateTxtFile = outputSettings[2];

            List<string[]> textFilesToCreate = new List<string[]>();

            string currentDateAndTime = string.Format("{0:MM-dd-yyyy_HH-mm-ss}", DateTime.Now);

            string direction;
            bool outputDirection = true;
            //string writeOutputPath;

            if (initialFacingRight == true)
                direction = "Initially Facing R";
            else
                direction = "Initially Facing L";

            string displayInputLog;


            if (recordingOption < 5)
            {
                displayInputLog = string.Empty;

                displayInputLog = GenerateInputLog(recordingOption, dictInputLogs[recordingOption]);

                if (generateTxtFile == true)
                {
                    textFilesToCreate.Clear();
                    textFilesToCreate = GenerateTextFiles(displayInputLog, textFilesToCreate, recordingOption, direction, outputDirection, currentDateAndTime);
                }
            }
            else
            {
                List<string>[] AllInputLogs = { inputLog, inputLog2, inputLog3, inputLog4, inputLog5 };
                List<string> AllOutputLogs = new() {GenerateInputLog(0, inputLog), GenerateInputLog(1, inputLog2), GenerateInputLog(2, inputLog3),
                                                    GenerateInputLog(3, inputLog4), GenerateInputLog(4, inputLog5)};

                textboxParsedRecordingKEY.Text = string.Join("---------------------------" + Environment.NewLine, AllOutputLogs.Select(log => string.Join(Environment.NewLine, log)));

                if (generateTxtFile == true)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        textFilesToCreate.Clear();
                        displayInputLog = GenerateInputLog(i + 1, AllInputLogs[i]);
                        textFilesToCreate = GenerateTextFiles(displayInputLog, textFilesToCreate, recordingOption, direction, outputDirection, currentDateAndTime);
                    }
                }
            }



            /*switch (recordingOption)
            {

                case 0:
                    displayInputLog = string.Empty;

                    displayInputLog = GenerateInputLog(recordingOption + 1, inputLog2);

                    if (generateTxtFile == true)
                        textFilesToCreate.Clear();
                        textFilesToCreate = GenerateTextFiles(displayInputLog, textFilesToCreate, recordingOption + 1, direction, currentDateAndTime);

                    break;

                case 1:
                    displayInputLog = string.Empty;

                    displayInputLog = GenerateInputLog(recordingOption + 1, inputLog2);

                    if (generateTxtFile == true)
                        textFilesToCreate.Clear();
                        textFilesToCreate = GenerateTextFiles(displayInputLog, textFilesToCreate, recordingOption + 1, direction, currentDateAndTime);

                    break;

                case 2:
                    displayInputLog = string.Empty;

                    displayInputLog = GenerateInputLog(recordingOption + 1, inputLog2);

                    if (generateTxtFile == true)
                        textFilesToCreate.Clear();
                        textFilesToCreate = GenerateTextFiles(displayInputLog, textFilesToCreate, recordingOption + 1, direction, currentDateAndTime);

                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;
                    *//*case 1:
                        string displayInputLog2 = "";
                        displayInputLog2 += "Recording " + (recordingOption + 1) + System.Environment.NewLine;
                        displayInputLog2 += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLog2 += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLog2 += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog2)
                        {
                            displayInputLog2 += key + System.Environment.NewLine;
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, displayInputLog2);
                        }
                        textboxParsedRecordingKEY.Text = displayInputLog2;
                        break;
                    case 2:
                        string displayInputLog3 = "";
                        displayInputLog3 += "Recording " + (recordingOption + 1) + System.Environment.NewLine;
                        displayInputLog3 += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLog3 += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLog3 += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog3)
                        {
                            displayInputLog3 += key + System.Environment.NewLine;
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, displayInputLog3);
                        }
                        textboxParsedRecordingKEY.Text = displayInputLog3;
                        break;
                    case 3:
                        string displayInputLog4 = "";
                        displayInputLog4 += "Recording " + (recordingOption + 1) + System.Environment.NewLine;
                        displayInputLog4 += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLog4 += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLog4 += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog4)
                        {
                            displayInputLog4 += key + System.Environment.NewLine;
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, displayInputLog4);
                        }
                        textboxParsedRecordingKEY.Text = displayInputLog4;
                        break;
                    case 4:
                        string displayInputLog5 = "";
                        displayInputLog5 += "Recording " + (recordingOption + 1) + System.Environment.NewLine;
                        displayInputLog5 += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLog5 += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLog5 += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog5)
                        {
                            displayInputLog5 += key + System.Environment.NewLine;
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, displayInputLog5);
                        }
                        textboxParsedRecordingKEY.Text = displayInputLog5;
                        break;
                    case 5:
                        string displayInputLogAll = "";
                        string record1 = "", record2 = "", record3 = "", record4 = "", record5 = "";
                        List<string> currentRecording = new List<string>();
                        displayInputLogAll += "Recording " + 1 + System.Environment.NewLine;
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLogAll += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLogAll += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog)
                        {
                            displayInputLogAll += key + System.Environment.NewLine;
                            currentRecording.Add(key);
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            currentRecording.Insert(0, "Recording" + " 1");
                            currentRecording.Insert(1, "---------------------------");
                            if (checkboxOutputKEY.Checked)
                            {
                                currentRecording.Insert(2, "-KEY-");
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                currentRecording.Insert(2, "-EKEY-");
                            }
                            foreach (string x in currentRecording)
                            {
                                record1 += x + System.Environment.NewLine;
                            }
                            currentRecording.Clear();
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 1, " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 1, " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, record1);
                        }
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        displayInputLogAll += "Recording " + 2 + System.Environment.NewLine;
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLogAll += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLogAll += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog2)
                        {
                            displayInputLogAll += key + System.Environment.NewLine;
                            currentRecording.Add(key);
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            currentRecording.Insert(0, "Recording" + " 2");
                            currentRecording.Insert(1, "---------------------------");
                            if (checkboxOutputKEY.Checked)
                            {
                                currentRecording.Insert(2, "-KEY-");
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                currentRecording.Insert(2, "-EKEY-");
                            }
                            foreach (string x in currentRecording)
                            {
                                record2 += x + System.Environment.NewLine;
                            }
                            currentRecording.Clear();
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 2, " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 2, " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, record2);
                        }
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        displayInputLogAll += "Recording " + 3 + System.Environment.NewLine;
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLogAll += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLogAll += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog3)
                        {
                            displayInputLogAll += key + System.Environment.NewLine;
                            currentRecording.Add(key);
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            currentRecording.Insert(0, "Recording" + " 3");
                            currentRecording.Insert(1, "---------------------------");
                            if (checkboxOutputKEY.Checked)
                            {
                                currentRecording.Insert(2, "-KEY-");
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                currentRecording.Insert(2, "-EKEY-");
                            }
                            foreach (string x in currentRecording)
                            {
                                record3 += x + System.Environment.NewLine;
                            }
                            currentRecording.Clear();
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 3, " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 3, " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, record3);
                        }
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        displayInputLogAll += "Recording " + 4 + System.Environment.NewLine;
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLogAll += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLogAll += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog4)
                        {
                            displayInputLogAll += key + System.Environment.NewLine;
                            currentRecording.Add(key);
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            currentRecording.Insert(0, "Recording" + " 4");
                            currentRecording.Insert(1, "---------------------------");
                            if (checkboxOutputKEY.Checked)
                            {
                                currentRecording.Insert(2, "-KEY-");
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                currentRecording.Insert(2, "-EKEY-");
                            }
                            foreach (string x in currentRecording)
                            {
                                record4 += x + System.Environment.NewLine;
                            }
                            currentRecording.Clear();
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 4, " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 4, " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, record4);
                        }
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        displayInputLogAll += "Recording " + 5 + System.Environment.NewLine;
                        displayInputLogAll += "---------------------------" + System.Environment.NewLine;
                        if (checkboxOutputKEY.Checked)
                        {
                            displayInputLogAll += "-KEY-" + System.Environment.NewLine;
                        }
                        if (checkboxOutputEKEY.Checked)
                        {
                            displayInputLogAll += "-EKEY-" + System.Environment.NewLine;
                        }
                        foreach (string key in inputLog5)
                        {
                            displayInputLogAll += key + System.Environment.NewLine;
                            currentRecording.Add(key);
                        }
                        if (modeSelectGenerateTxt == true)
                        {
                            currentRecording.Insert(0, "Recording" + " 5");
                            currentRecording.Insert(1, "---------------------------");
                            if (checkboxOutputKEY.Checked)
                            {
                                currentRecording.Insert(2, "-KEY-");
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                currentRecording.Insert(2, "-EKEY-");
                            }
                            foreach (string x in currentRecording)
                            {
                                record5 += x + System.Environment.NewLine;
                            }
                            currentRecording.Clear();
                            writeOutputPath = "";
                            if (checkboxOutputKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 5, " + direction + ", " + outputRight + ", " + currentDateAndTime + ".txt";
                            }
                            if (checkboxOutputEKEY.Checked)
                            {
                                writeOutputPath = defaultOutputPath + "\\" + "Recording 5, " + direction + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
                            }
                            File.WriteAllText(writeOutputPath, record5);
                        }
                        textboxParsedRecordingKEY.Text = displayInputLogAll;
                        Console.Write(displayInputLogAll);
                        break;*//*
            }*/

            foreach (string[] text in textFilesToCreate)
                File.WriteAllText(text[0], text[1]);
        }
        private string GenerateInputLog(int recordingOption, List<string> inputLog)
        {
            string displayInputLog = string.Empty;

            displayInputLog += "Recording " + (recordingOption + 1) + System.Environment.NewLine;
            displayInputLog += "---------------------------" + System.Environment.NewLine;
            displayInputLog += "-KEY-" + System.Environment.NewLine;

            foreach (string key in inputLog)
                displayInputLog += key + System.Environment.NewLine;

            displayInputLog = displayInputLog.TrimEnd();

            if (recordingOption != 5)
                textboxParsedRecordingKEY.Text = displayInputLog;

            return displayInputLog;
        }

        /*private string CreateInputLogDisplay(int recordingOption, List<string> inputLog)
        {
            string displayInputLog = string.Empty;

            displayInputLog = GenerateInputLog(recordingOption + 1, inputLog);
            textboxParsedRecordingKEY.Text = displayInputLog;
            
            return displayInputLog;
        }*/

        private List<string[]> GenerateTextFiles(string displayInputLog, List<string[]> textFilesToCreate, int recordingOption, string direction, bool outputDirection, string currentDateAndTime)
        {
            string writeOutputPath = string.Empty;
            string outputLeft = "Adjusted to Face Left";
            string outputRight = "Adjusted to Face Right";

            //If output direction == true, use Facing Right. Otherwise, use Facing Left.
            if (outputDirection == true && direction.Equals("Initially Facing L"))
            {
                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + outputRight + ", " + currentDateAndTime + ".txt";
            }
            else if (outputDirection == false && direction.Equals("Initially Facing R"))
            {
                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + outputLeft + ", " + currentDateAndTime + ".txt";
            }
            else
            {
                writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + currentDateAndTime + ".txt";
            }

            //string writeOutputPath = defaultOutputPath + "\\" + "Recording " + (recordingOption + 1) + ", " + direction + ", " + currentDateAndTime + ".txt";
            textFilesToCreate.Add(new string[] { writeOutputPath, displayInputLog });

            return textFilesToCreate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Output Default Save/Output Directory
            textboxSaveDirectory.Text = saveFilePath;
            textboxOutputDirectory.Text = defaultOutputPath;
            //Try Catch to see if Output Directory Exists
            try
            {
                // If the directory doesn't exist, create it.
                if (!Directory.Exists(defaultOutputPath))
                {
                    Directory.CreateDirectory(defaultOutputPath);
                }
            }
            catch (Exception)
            {
                // Fail silently
            }
            //MenuStrip Use Wait Cursor Disabled
            menuStrip1.UseWaitCursor = false;
            //Setup Tooltips for each button
            ToolTip toolTipper = new ToolTip();
            toolTipper.SetToolTip(checkboxOutputTxtFiles, "When checked, the program will output the selected recording(s) as .txt files inside of the output directory.");
            toolTipper.SetToolTip(radioRecording1, "When checked, the program will create an output for just recording 1.");
            toolTipper.SetToolTip(radioRecording2, "When checked, the program will create an output for just recording 2.");
            toolTipper.SetToolTip(radioRecording3, "When checked, the program will create an output for just recording 3.");
            toolTipper.SetToolTip(radioRecording4, "When checked, the program will create an output for just recording 4.");
            toolTipper.SetToolTip(radioRecording5, "When checked, the program will create an output for just recording 5.");
            toolTipper.SetToolTip(radioRecordingAll, "When checked, the program will create an output for all recordings.");
            toolTipper.SetToolTip(btnParse, "When pressed, the program will create the output in the respective direction and settings selected.");
        }
        private void StripMenuOpen_Click(object sender, EventArgs e) //Update File Directory for P4U2 Save File
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = appDataFolder + "\\P4U2\\Save";
            openFileDialog1.DefaultExt = "dat";
            openFileDialog1.Filter = "dat files (*.dat)|*.dat";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = openFileDialog1.FileName;
                textboxSaveDirectory.Text = saveFilePath;
            }
        }
        private void StripMenuSetOutput_Click(object sender, EventArgs e)//Update Output Directory for Parsed Input Files 
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.Description = "Select an output directory that is easy to recall and relocate.";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                defaultOutputPath = fbd.SelectedPath;
                textboxOutputDirectory.Text = defaultOutputPath;
            }
        }
        private void StripMenuClose_Click(object sender, EventArgs e)//Close Program 
        {
            Close();
        }
        private void StripMenuDocumentation_Click(object sender, EventArgs e)//Opens Link to Github documentation page 
        {
            string target = "https://github.com/Karasu456/P4U2-Training-Mode-Recording-Input-Parser/wiki";
            try
            {
                System.Diagnostics.Process.Start("cmd", "/c start " + target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
        private void StripMenuAbout_Click(object sender, EventArgs e)//Opens New Form with information about the program 
        {
            Form2 myForm = new Form2();
            myForm.StartPosition = FormStartPosition.CenterParent;
            myForm.ShowDialog();
        }
        private void BtnParse_Click(object sender, EventArgs e) //Displays User P4U2 Save Data according to recording selected, direction faced, and output mode
        {
            int recordingOption = 0;
            bool initialFacingRight = true, outputFacingRight = true, generateTxtFile = false;

            //Erroneous Input Checks
            /*failedInputCheck = false;
            NoDirectionAndNoOuputSelected();
            DirectionPresentAndNoOutputSelected();
            OutputPresentAndMultipleDirectionsPresent();
            DirectionPresentAndMultipleOutputsPresent();*/

            //Check for recording option selected
            if (radioRecording1.Checked)
            {
                recordingOption = 0;
            }
            if (radioRecording2.Checked)
            {
                recordingOption = 1;
            }
            if (radioRecording3.Checked)
            {
                recordingOption = 2;
            }
            if (radioRecording4.Checked)
            {
                recordingOption = 3;
            }
            if (radioRecording5.Checked)
            {
                recordingOption = 4;
            }
            if (radioRecordingAll.Checked)
            {
                recordingOption = 5;
            }

            //Initail Direction Setting
            if (radioInitialDirectionLeft.Checked)
                initialFacingRight = false;

            if (radioInitialDirectionRight.Checked)
                initialFacingRight = true;

            //Output Direction Setting
            if (radioOutputDirectionRight.Checked)
                outputFacingRight = true;

            if (radioOutputDirectionLeft.Checked)
                outputFacingRight = false;

            //Generate Text File Setting
            if (checkboxOutputTxtFiles.Checked)
            {
                generateTxtFile = true;
            }

            //Sorted Recording data from save.dat
            List<string>[] sortedRecordings = SortRecordings(saveFilePath);

            //Parsing Settings
            bool[] outputSettings = { initialFacingRight, outputFacingRight, generateTxtFile };

            //Recording 1
            List<string> inputLog = ConstructInputLog(sortedRecordings[0], outputSettings);
            //List<string> eInputLog = inputLog;

            //Recording 2
            List<string> inputLog2 = ConstructInputLog(sortedRecordings[1], outputSettings);
            //List<string> eInputLog2 = inputLog2;

            //Recording 3
            List<string> inputLog3 = ConstructInputLog(sortedRecordings[2], outputSettings);

            //Recording 4
            List<string> inputLog4 = ConstructInputLog(sortedRecordings[3], outputSettings);

            //Recording 5
            List<string> inputLog5 = ConstructInputLog(sortedRecordings[4], outputSettings);

            //All Recordings
            List<string>[] inputLogs = { inputLog, inputLog2, inputLog3, inputLog4, inputLog5 };

            //Displaying and Writing Data
            DisplayAndWriteData(inputLogs, outputSettings, recordingOption);

        }

        private void BtnClear_Click(object sender, EventArgs e)//Clear Textboxes in Form 
        {
            textboxParsedRecordingKEY.Text = "";
        }
    }
}