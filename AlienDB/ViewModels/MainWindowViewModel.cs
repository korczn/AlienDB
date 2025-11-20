using System.Collections.ObjectModel;
using AlienDB.Models;
using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;
using System;

namespace AlienDB.ViewModels;

public class MainWindowViewModel : ViewModelBase
{



    public ObservableCollection<AlienDB_Model> Movies { get; } = new()
    {
        new AlienDB_Model()
        {
            Title = "Alien",
            PolishTitle = "Obcy - ósmy pasażer Nostromo",
            Year = 1979,
            Director = "Ridley Scott",
            Scenario = "Dan O' Bannon",
            Genre = "Sci-Fi / Horror",
            MovieTime = "117 minut",
            Rating = 8.5,
            MainCharacters = "Ellen Ripley, Dallas, Ash, Lambert, Kane",
            Ship = "USCSS Nostromo"

        },
        
        new AlienDB_Model()
        {
            Title = "Aliens",
            PolishTitle = "Obcy - decydujące starcie",
            Year = 1986,
            Director = "James Cameron",
            Scenario = "James Cameron, David Giler, Walter Hill",
            Genre = "Sci-Fi / Action / Horror",
            MovieTime = "137 minut",
            Rating = 8.4,
            MainCharacters = "Ellen Ripley, Hicks, Newt, Bishop, Vasques",
            Ship = "USS Sulaco"

        },
        
        new AlienDB_Model()
        {
            Title = "Alien 3",
            PolishTitle = "Obcy 3",
            Year = 1992,
            Director = "David Flincher",
            Scenario = "David Giler, Walter Hill, Larry Ferguson",
            Genre = "Sci-Fi / Horror",
            MovieTime = "114 minut",
            Rating = 6.5,
            MainCharacters = "Ellen Ripley, Dillon, Clemens, Morse, Andrews",
            Ship = "E.E.V. z USS Sulaco (katastrofa)"

        },
        
        new AlienDB_Model()
        {
            Title = "Alien: Resurrection",
            PolishTitle = "Obcy: Przebudzenie",
            Year = 1997,
            Director = "Jean-Pierre Jeunet",
            Scenario = "Joss Whedon",
            Genre = "Sci-Fi / Horror",
            MovieTime = "109 minut",
            Rating = 8.2,
            MainCharacters = "Ellen Ripley (klon), Call, Johner, Christie, Dr. Gediman",
            Ship = "USM Auriga"

        },
        
        new AlienDB_Model()
        {
            Title = "Prometheus",
            PolishTitle = "Prometeusz",
            Year = 2012,
            Director = "Ridley Scott",
            Scenario = "Jon Spaihts, Damon Lidelof",
            Genre = "Sci-Fi / Thriller",
            MovieTime = "124 minut",
            Rating = 7.0,
            MainCharacters = "Elizabeth Shaw, David, Charlie Holloway, Meredith Vickers",
            Ship = "USCSS Prometheus"

        },
        
        new AlienDB_Model()
        {
            Title = "Alien: Covenant",
            PolishTitle = "Obcy: Przymierze",
            Year = 2017,
            Director = "Ridley Scott",
            Scenario = "John Logan, Dante Harper",
            Genre = "Sci-Fi / Horror",
            MovieTime = "122 minut",
            Rating = 6.4,
            MainCharacters = "Daniels, David, Walter, Oram, Tennessee",
            Ship = "USCSS Covenant"

        },
        
    };
}