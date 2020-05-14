using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreDiscord;
using CoreTwitter;
using System.Drawing;

namespace Core
{
    public class FileHelper
    {

        public static async Task ExportAlerts(List<Alert> Alerts)
        {
                Alerts = Alerts.OrderByDescending(a => a.CreationTime).ToList();

                string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.DataAlerts), "Alerts.csv");
                using (StreamWriter write = new StreamWriter(FilePath, false))
                {
                    CsvWriter csw = new CsvWriter(write, CultureInfo.InvariantCulture);
                    csw.WriteHeader<Alert>(); // writes the csv header for this class
                    csw.NextRecord();
                    csw.WriteRecords(Alerts);
                }
        }

        public static async Task<List<Alert>> ImportAlerts()
        {
            string FilePath = Constants.AppFolder(Constants.AppDirectory.DataAlerts);
            List <Alert> Alerts = new List<Alert>();
            if (!String.IsNullOrEmpty(FilePath))
            {
                // First see if we have the file we want where we want it. To do that, we need to get the filepath to our app folder in my documents
                if (Directory.Exists(FilePath))
                {
                    // We can only do this because the directory exists
                    // Now check if the file exists
                    string ourfilepath = Path.Combine(FilePath, "Alerts.csv");

                    // Get trade info, and Account balance
                    if (File.Exists(ourfilepath))
                    {
                        // handle backward compatibility: if new fields were added, the CsvReader cannot find these and throws a CsvHelper.ValidationException.
                        // in this case, we try to load the csv with our compatibility class that we copied before the additional fields were added and this shoudl go fine.
                        // after that we create the new instances out of the old values and add default values for the new fields.
                        try
                        {
                            using (var reader = new CsvReader(new StreamReader(ourfilepath), CultureInfo.InvariantCulture))
                            {
                                Alerts = reader.GetRecords<Alert>().ToList();
                            }
                        }
                        catch (CsvHelper.ValidationException valex)
                        {
                        }
                    }
                }
            }

            return Alerts;
        }

    
       

        public static async Task ExportTwitterSettings(TwitterSettings TwitterSettings)
        {
            List<TwitterSettings> ToWrite = new List<TwitterSettings>();
            ToWrite.Add(TwitterSettings);

            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.DataTwitterSettings));
                //TwitterSettings = TwitterSettings;

                FilePath = Path.Combine(FilePath, "TwSettings.csv");
                using (StreamWriter write = new StreamWriter(FilePath, false))
                {
                    CsvWriter csw = new CsvWriter(write, CultureInfo.InvariantCulture);
                    csw.WriteHeader<TwitterSettings>(); // writes the csv header for this class
                    csw.NextRecord();
                    csw.WriteRecords(ToWrite); //WriteRecords, if you convert to list.
                }
        }

        public static async Task<TwitterSettings> ImportTwitterSettings()
        {
            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.DataTwitterSettings));
            TwitterSettings TwitterSettings = new TwitterSettings();
            if (!String.IsNullOrEmpty(FilePath))
            {
                // First see if we have the file we want where we want it. To do that, we need to get the filepath to our app folder in my documents
                if (Directory.Exists(FilePath))
                {
                    // We can only do this because the directory exists
                    // Now check if the file exists
                    string ourfilepath = Path.Combine(FilePath, "TwSettings.csv");

                    // Get trade info, and Account balance
                    if (File.Exists(ourfilepath))
                    {
                        // handle backward compatibility: if new fields were added, the CsvReader cannot find these and throws a CsvHelper.ValidationException.
                        // in this case, we try to load the csv with our compatibility class that we copied before the additional fields were added and this shoudl go fine.
                        // after that we create the new instances out of the old values and add default values for the new fields.
                        try
                        {
                            using (var reader = new CsvReader(new StreamReader(ourfilepath), CultureInfo.InvariantCulture))
                            {
                                TwitterSettings = reader.GetRecords<TwitterSettings>().FirstOrDefault();
                            }
                        }
                        catch (CsvHelper.ValidationException valex)
                        {
                        }
                    }
                }
            }

            return TwitterSettings;
        }


        public static async Task ExportScreenshotSettings(ScreenshotSettings ScreenshotSettings)
        {
            List<ScreenshotSettings> ToWrite = new List<ScreenshotSettings>();
            ToWrite.Add(ScreenshotSettings);

            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.ScreenshotSettings));
            //ScreenshotSettings = ScreenshotSettings;

            FilePath = Path.Combine(FilePath, "ScreenshotSettings.csv");
            using (StreamWriter write = new StreamWriter(FilePath, false))
            {
                CsvWriter csw = new CsvWriter(write, CultureInfo.InvariantCulture);
                csw.WriteHeader<ScreenshotSettings>(); // writes the csv header for this class
                csw.NextRecord();
                csw.WriteRecords(ToWrite); //WriteRecords, if you convert to list.
            }
        }

        public static async Task<ScreenshotSettings> ImportScreenshotSettings()
        {
            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.ScreenshotSettings));
            ScreenshotSettings ScreenshotSettings = new ScreenshotSettings();
            if (!String.IsNullOrEmpty(FilePath))
            {
                // First see if we have the file we want where we want it. To do that, we need to get the filepath to our app folder in my documents
                if (Directory.Exists(FilePath))
                {
                    // We can only do this because the directory exists
                    // Now check if the file exists
                    string ourfilepath = Path.Combine(FilePath, "ScreenshotSettings.csv");

                    // Get trade info, and Account balance
                    if (File.Exists(ourfilepath))
                    {
                        // handle backward compatibility: if new fields were added, the CsvReader cannot find these and throws a CsvHelper.ValidationException.
                        // in this case, we try to load the csv with our compatibility class that we copied before the additional fields were added and this shoudl go fine.
                        // after that we create the new instances out of the old values and add default values for the new fields.
                        try
                        {
                            using (var reader = new CsvReader(new StreamReader(ourfilepath), CultureInfo.InvariantCulture))
                            {
                                ScreenshotSettings = reader.GetRecords<ScreenshotSettings>().FirstOrDefault();
                            }
                        }
                        catch (CsvHelper.ValidationException valex)
                        {
                        }
                    }
                }
            }

            return ScreenshotSettings;
        }

        public static async Task ExportDiscordSettings(DiscordSettings DiscordSettings)
        {
            List<DiscordSettings> ToWrite = new List<DiscordSettings>();
            ToWrite.Add(DiscordSettings);

            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.DataDiscordSettings));

                //DiscordSettings = DiscordSettings;

                FilePath = Path.Combine(FilePath, "DsSettings.csv");
                using (StreamWriter write = new StreamWriter(FilePath, false))
                {
                    CsvWriter csw = new CsvWriter(write, CultureInfo.InvariantCulture);
                    csw.WriteHeader<DiscordSettings>(); // writes the csv header for this class
                    csw.NextRecord();
                    csw.WriteRecords(ToWrite); //WriteRecords, if you convert to list.
                }
        }

        public static async Task<DiscordSettings> ImportDiscordSettings()
        {
            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.DataDiscordSettings));
            DiscordSettings DiscordSettings = new DiscordSettings();
            if (!String.IsNullOrEmpty(FilePath))
            {
                // First see if we have the file we want where we want it. To do that, we need to get the filepath to our app folder in my documents
                if (Directory.Exists(FilePath))
                {
                    // We can only do this because the directory exists
                    // Now check if the file exists
                    string ourfilepath = Path.Combine(FilePath, "DsSettings.csv");

                    // Get trade info, and Account balance
                    if (File.Exists(ourfilepath))
                    {
                        // handle backward compatibility: if new fields were added, the CsvReader cannot find these and throws a CsvHelper.ValidationException.
                        // in this case, we try to load the csv with our compatibility class that we copied before the additional fields were added and this shoudl go fine.
                        // after that we create the new instances out of the old values and add default values for the new fields.
                        try
                        {
                            using (var reader = new CsvReader(new StreamReader(ourfilepath), CultureInfo.InvariantCulture))
                            {
                                DiscordSettings = reader.GetRecords<DiscordSettings>().FirstOrDefault();
                            }
                        }
                        catch (CsvHelper.ValidationException valex)
                        {
                        }
                    }
                }
            }

            return DiscordSettings;
        }

        public static async Task ExportAlertSettings(AlertSettings AlertSettings)
        {
            List<AlertSettings> ToWrite = new List<AlertSettings>();
            ToWrite.Add(AlertSettings);

            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.DataAlertSettings));
            //AlertSettings = AlertSettings;

            FilePath = Path.Combine(FilePath, "AlertSettings.csv");
            using (StreamWriter write = new StreamWriter(FilePath, false))
            {
                CsvWriter csw = new CsvWriter(write, CultureInfo.InvariantCulture);
                csw.WriteHeader<AlertSettings>(); // writes the csv header for this class
                csw.NextRecord();
                csw.WriteRecords(ToWrite); //WriteRecords, if you convert to list.
            }
        }

        public static async Task<AlertSettings> ImportAlertSettings()
        {
            string FilePath = Path.Combine(Constants.AppFolder(Constants.AppDirectory.DataAlertSettings));
            AlertSettings AlertSettings = new AlertSettings();
            if (!String.IsNullOrEmpty(FilePath))
            {
                // First see if we have the file we want where we want it. To do that, we need to get the filepath to our app folder in my documents
                if (Directory.Exists(FilePath))
                {
                    // We can only do this because the directory exists
                    // Now check if the file exists
                    string ourfilepath = Path.Combine(FilePath, "AlertSettings.csv");

                    // Get trade info, and Account balance
                    if (File.Exists(ourfilepath))
                    {
                        // handle backward compatibility: if new fields were added, the CsvReader cannot find these and throws a CsvHelper.ValidationException.
                        // in this case, we try to load the csv with our compatibility class that we copied before the additional fields were added and this shoudl go fine.
                        // after that we create the new instances out of the old values and add default values for the new fields.
                        try
                        {
                            using (var reader = new CsvReader(new StreamReader(ourfilepath), CultureInfo.InvariantCulture))
                            {
                                AlertSettings = reader.GetRecords<AlertSettings>().FirstOrDefault();
                            }
                        }
                        catch (CsvHelper.ValidationException valex)
                        {
                        }
                    }
                }
            }

            return AlertSettings;
        }

        public static List<string> GetCsvHeader(string file)
        {
            List<string> result = new List<string>();
            try
            {
                StreamReader stream = new StreamReader(file);
                CsvReader reader = new CsvReader(stream, CultureInfo.InvariantCulture);
                //reader.ReadHeader();
                result.AddRange(reader.Parser.Read());
            }
            catch { }
            return result;
        }
    }
}
