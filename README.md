# ML.NET + MAUI .NET Conf 2021 Source Code

Source code from .NET Conf 2021 ML.NET presentation.

MAUI app code can be found in the [transfer-app](https://github.com/luisquintanilla/dotnet-conf-2021-ml/tree/transfer-app).

## Setup

To run this application, you need .NET MAUI Preview 10+. See this [.NET MAUI Preview 10 blog post](https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-10/) for more information.

## About this app

This application is a .NET MAUI application that uses an ML.NET machine learning model to repair missing / damaged notes in a song.

## About the dataset

TODO

## Additional Dependencies

- [Manufaktura.Controls](http://manufaktura-controls.com/en-US/Articles/) ([Repo](https://bitbucket.org/Ajcek/manufakturalibraries/src/master/)) - Musical symbol rendering.
- [DryWetMIDI](https://melanchall.github.io/drywetmidi/) ([Repo](https://github.com/melanchall/drywetmidi)) - MIDI file generation. Generation is done outside of the MAUI app.
- [Xam.Plugin.SimpleAudioPlayer](https://www.nuget.org/packages/Xam.Plugin.SimpleAudioPlayer) ([Repo](https://github.com/adrianstevens/Xamarin-Plugins/tree/master/SimpleAudioPlayer)) - MIDI playback
