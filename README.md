# Overview

One of the earliest projects I worked on was a text adventure game, but it was very elementary because at the time I only really knew how to assign variables and use if/else statements.

This project is the making of a text adventure, but it isn't really a text adventure yet. I got through some of the planning and came up with a bare-bones structure for the game, but the text itself isn't ready and the structure is super simple - right now there's only three rooms, they're linear, and nothing really happens.

The reason I made this is because I wanted to practice and refresh myself on C#, which I studied once long ago but I've almost forgotten everything. (Indeed, I had to relearn a lot while doing this.)

[Software Demo Video](http://youtube.link.goes.here)

# Development Environment

For this project, I used primarily VS Code. I'd never created a C# project from scratch before, so I also downloaded and used .NET 8.0, which I used both to create and debug the project.

The interesting thing about this is that I'm pretty sure there's a different, better way to do this than how I did it - old C# exercises I used to do would be compiled and run in the terminal itself, but this one is run in the debug menu. I'm not actually sure why or how to change/fix it yet, but that's another thing I hope to learn.


# Useful Websites

As always, W3 Schools has a great tutorial on C#. Youtube also has a lot of great tutorials, though there wasn't one that helped me as much this time as W3 Schools did.

- [W3 Schools: C# Tutorial](https://www.w3schools.com/cs/index.php)
- [Youtube](https://www.youtube.com)

# Future Work

Things to fix, add, and improve include:

- Adding actual adventue text to the game rather than all the placeholders that are in it right now
- Adding items, which I set up for but haven't yet added. The idea for these would be mostly weapons, armor, and healing items, that would help the player fight enemies and then heal afterward.
- Adding enemies. I made a class for them, but haven't actually added any. I was planning to add a bear to the mountains area, and a pirate or some other type of person to the beach.
- Adding more areas. I originally had about a dozen areas planned, but only was able to implement three for the purposes of this demo.
- Adding choice-based changes to the text/story. I've set this up already too by giving the player a "choice list" element that records all their choices.
