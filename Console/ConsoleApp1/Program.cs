using Domain;

DateTime startTime = DateTime.Now;
ImageProxy img1 = new ImageProxy("Pamela Anderson");
ImageProxy img2 = new ImageProxy("Kim Kardashian");
ImageProxy img3 = new ImageProxy("Kirby Griffin");
Section playboyS1 = new Section("Front Cover");
playboyS1.add(img1);
Section playboyS2 = new Section("Summer Girls");
playboyS2.add(img2);
playboyS2.add(img3);
Book playboy = new Book("Playboy");

playboy.add(playboyS1);
playboy.add(playboyS2);
DateTime endTime = DateTime.Now;
Console.WriteLine("Creation of the content took " + (endTime -
startTime) + " milliseconds");
startTime = DateTime.Now;
playboyS1.print();
endTime = DateTime.Now;
Console.WriteLine("Printing of the section 1 took " + (endTime -
startTime) + " milliseconds");
startTime = DateTime.Now;
playboyS1.print();
endTime = DateTime.Now;
Console.WriteLine("Printing again the section 1 took " + (endTime -
startTime) + " milliseconds");
