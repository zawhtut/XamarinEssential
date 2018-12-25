﻿using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinEssential.ViewModel
{
    class ShareViewModel : BaseViewModel
    {
        bool shareText = true;
        bool shareUri;
        string text;
        string uri;
        string subject;
        string title;

        public ICommand RequestCommand { get; }

        public ShareViewModel()
        {
            RequestCommand = new Command(OnRequest);
        }

        public bool ShareText
        {
            get => shareText;
            set => SetProperty(ref shareText, value);
        }

        public bool ShareUri
        {
            get => shareUri;
            set => SetProperty(ref shareUri, value);
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Uri
        {
            get => uri;
            set => SetProperty(ref uri, value);
        }

        public string Subject
        {
            get => subject;
            set => SetProperty(ref subject, value);
        }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        async void OnRequest()
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Subject = Subject,
                Text = ShareText ? Text : null,
                Uri = ShareUri ? Uri : null,
                Title = Title
            });
        }
    }
}
