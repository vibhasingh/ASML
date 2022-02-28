﻿// (C) ASML 2022 Submitted for Interview assignment

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ASML.InterviewTest.Infra
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}