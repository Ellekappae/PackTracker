﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PackChronicler.Entity;
using MahApps.Metro.Controls;
using System.Collections.ObjectModel;
using Hearthstone_Deck_Tracker.Hearthstone;
//using HearthDb;

namespace PackChronicler.Controls {
  /// <summary>
  /// Interaktionslogik für History.xaml
  /// </summary>
  public partial class History {
    public History(PackChronicler.History History) {
      InitializeComponent();
      lv_Cards.ItemsSource = History;
    }
  }
}