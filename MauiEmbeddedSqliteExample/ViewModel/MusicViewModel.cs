using MauiEmbeddedSqliteExample.Models;
using MauiEmbeddedSqliteExample.Services;
using System.Collections.ObjectModel;

namespace MauiEmbeddedSqliteExample.ViewModel
{
    public class MusicViewModel : BaseViewModel
    {
        private MusicDatabaseService _musicDatabaseService;
        private ObservableCollection<Tracks> _tracks;

        public ObservableCollection<Tracks> Tracks
        {
            get { return _tracks; }
            set { _tracks = value;

                OnPropertyChanged();
            }
        }


        public MusicViewModel(MusicDatabaseService musicDatabaseService)
        {
            _musicDatabaseService = musicDatabaseService;

            
        }
        public override void OnAppearing()
        {
            base.OnAppearing();

            Tracks = new ObservableCollection<Tracks>(_musicDatabaseService.GetTracks());
        }
    }
}
