# ML.NET + MAUI .NET Conf 2021 Source Code

Source code from .NET Conf 2021 ML.NET presentation.

MAUI app code can be found in the [transfer-app](https://github.com/luisquintanilla/dotnet-conf-2021-ml/tree/transfer-app).

## Setup

To run this application, you need .NET MAUI Preview 10+. See this [.NET MAUI Preview 10 blog post](https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-10/) for more information.

## About this app

This application is a .NET MAUI application that uses an ML.NET machine learning model to repair missing / damaged notes in a song.

## About the dataset

The dataset used for training the ML.NET model (**chorales-modified.csv.txt**) is based on the [Bach Chorales Data Set](https://archive.ics.uci.edu/ml/datasets/Bach+Chorales) from UCI Machine Learning Repository.

The training dataset has ~4.6K rows and 24 columns which represent single-line melodies of 100 Bach chorales (songs).

The following is a preview of the first 10 rows of the dataset:

![image](https://user-images.githubusercontent.com/10437687/141131974-9a8cf169-e26f-4707-821b-e1d49ae7494e.png)

- **Chorale**: Indicates the song in the current row (1 is song #1, 2 is song #2, ...)
- **Key**: Indicates if the note in the row has any sharps or flats
- **Measure**: Indicates the section of the song/chorale in the current row (1 is first section, 2 is second section, ...)
- **Note**: Indicates the letter note; this is the Label since we want to predict missing notes
- **60, 61, 62, ... 79**: Indicates whether the note (number) is present in the same measure as the indicated note (letter); 0 = not present, 1 = present

## Additional Dependencies

- [Manufaktura.Controls](http://manufaktura-controls.com/en-US/Articles/) ([Repo](https://bitbucket.org/Ajcek/manufakturalibraries/src/master/)) - Musical symbol rendering.
- [DryWetMIDI](https://melanchall.github.io/drywetmidi/) ([Repo](https://github.com/melanchall/drywetmidi)) - MIDI file generation. Generation is done outside of the MAUI app.
- [Xam.Plugin.SimpleAudioPlayer](https://www.nuget.org/packages/Xam.Plugin.SimpleAudioPlayer) ([Repo](https://github.com/adrianstevens/Xamarin-Plugins/tree/master/SimpleAudioPlayer)) - MIDI playback
