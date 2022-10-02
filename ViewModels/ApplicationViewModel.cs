using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

using RQTimer.Data.Models;

namespace RQTimer.ViewModels;

public class ApplicationViewModel : NotifyPropertyChanged
{
    private string currentDirectory { get; set; }

    private ObservableCollection<BossSettings> _listOfBosses;

    public ObservableCollection<BossSettings> ListOfBosses
    {
        get { return _listOfBosses; }
        set
        {
            _listOfBosses = value;
            OnPropertyChanged("ListOfBosses");
        }
    }

    public ApplicationViewModel()
    {
        ObservableCollection<BossSettings> bosses = LoadJson<ObservableCollection<BossSettings>>(
            @"..\..\..\Data\Local\bosses.json");

        ListOfBosses = bosses;
    }

    public static T LoadJson<T>(string filePath) where T : class
    {
        using StreamReader r = new(filePath);
        string jsonStr = r.ReadToEnd();
        T? json = JsonConvert.DeserializeObject<T>(jsonStr);
        if (json == null)
            throw new Exception($"Error occured on deserialize json. Json path {filePath}");
        return json;
    }
}