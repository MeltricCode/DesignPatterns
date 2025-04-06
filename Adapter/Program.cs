using Adapter;
using Adapter.Concrete;
using Adapter.Interface;
using Adapter.Model;


// Adapter Pattern:
// A structural design pattern that allows objects with incompatible interfaces to collaborate.
// It works by wrapping an existing class with a new interface expected by the client.
// This is especially useful when integrating legacy code or third-party libraries
// without modifying their source code.

Console.ForegroundColor = ConsoleColor.Green;

String someXml = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";


IJsonParser<Note> parser = new XmlToJsonAdapter<Note>();
Note note = parser.ConvertToObj(someXml);

Console.WriteLine(parser.ConvertToJson(note));
                    
                    