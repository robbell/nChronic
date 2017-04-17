# nChronic.Core #

## Introduction ##
A natural language date parser for .Net Core written in C#. Originally written by Mike Schrag as a direct port of Ruby's chronic, later ported to .NET by [Robert Wilczynski](https://github.com/robertwilczynski), and finally converted to .NET Core by [Rob Bell](https://github.com/robbell)

## Usage ##


```csharp
DateTime.Now; 
  //=> Sun Aug 27 23:18:25 PDT 2006

var parser = new Parser();
parser.Parse("tomorrow");
  // => Mon Aug 28 12:00:00 PDT 2006

// Setting context
parser = new Parser(new Options { Context = Pointer.Type.Past });
parser.Parse("monday");
  // => Mon Aug 21 12:00:00 PDT 2006

parser = new Parser(new Options { Clock = () => new DateTime(2000, 1, 1)});
parser.Parse('may 27th')
  #=> Sat May 27 12:00:00 PDT 2000
```

## Credits ##
This is a port of https://github.com/mojombo/chronic inspired by https://github.com/samtingleff/jchronic. Please see those projects for further credits.

## License ##
Unless specified otherwise all is licensed under the MIT license. See LICENSE for details.
Logo is the creation of Alexander Moore and is licensed under the GNU/GPL license (via http://findicons.com/icon/232550/clock).
