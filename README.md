# DebugIt
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

## Description
Unity didn't like me doing `Debug.log(new char[] {(char)65, (char)66});` and gave me the crappy output of `System.Char[]`. Thank you Unity. Very cool. So I decided to make a few functions to (hopefully) let you throw anything into a debug.

## Usage
Current supported types:
* Idk literally any that works with generics

It does all primative types (int, string, bool, float, double, etc...), arrays of primative types and classes (int[], string[] float[], double[]), custom-classes (ik, very cool), enums.

It doesnt do arrays of arrays (currently). Dont do anything like int[][], it'll get upset and give you a response of `[][]` :(

Want to debug a thing? Here's how you do it with DebugIt: <br>
`DebugIt.LogIt(<your really cool variable goes here>);` <br>
That's it. It'll log the thing. <br>
(you can also do  type specific debugs if you really want, itll do the same thing anyway tho, such as `DebugIt.LogClass();`)

## License
This project is licensed under the [MIT] License - see the [LICENSE](https://github.com/ZeppelinGames/DebugIt/blob/master/LICENSE) file for details

## Check out my other shit
<a href="http://www.twitter.com/Zeppelin_Games"><img src="https://image.flaticon.com/icons/png/512/124/124021.png" width="48"></a>
<a href="https://zeppelin-games.itch.io/"><img src="https://storage.webcatalog.app/catalog/itch-io/itch-io-icon-filled.png" width="48"></a>
<a href="http://www.github.com/ZeppelinGames"><img src="https://icon-library.com/images/github-icon-png/github-icon-png-29.jpg" width="48"></a>

[contributors-shield]: https://img.shields.io/github/contributors/ZeppelinGames/DebugIt.svg?style=for-the-badge
[contributors-url]: https://github.com/ZeppelinGames/DebugIt/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ZeppelinGames/DebugIt.svg?style=for-the-badge
[forks-url]: https://github.com/ZeppelinGames/DebugIt/network/members
[stars-shield]: https://img.shields.io/github/stars/ZeppelinGames/DebugIt.svg?style=for-the-badge
[stars-url]: https://github.com/ZeppelinGames/DebugIt/stargazers
[issues-shield]: https://img.shields.io/github/issues/ZeppelinGames/DebugIt.svg?style=for-the-badge
[issues-url]: https://github.com/ZeppelinGames/DebugIt/issues
[license-shield]: https://img.shields.io/github/license/ZeppelinGames/DebugIt.svg?style=for-the-badge
[license-url]: https://github.com/ZeppelinGames/DebugIt/blob/master/LICENSE
