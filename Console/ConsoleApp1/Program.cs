using Domain;

Book book = new Book("title");
DocumentManager.getInstance().setBook(book);
Section cap1 = new Section("Capitolul 1");
book.add(cap1);
Paragraph p1 = new Paragraph("Paragraph 1");
cap1.add(p1);
Paragraph p2 = new Paragraph("Paragraph 2");
cap1.add(p2);
Paragraph p3 = new Paragraph("Paragraph 3");
cap1.add(p3);
Paragraph p4 = new Paragraph("Paragraph 4");
cap1.add(p4);
p1.setAlignStrategy(new AlignCenter());
p2.setAlignStrategy(new AlignRight());
p3.setAlignStrategy(new AlignLeft());
Console.WriteLine();
Console.WriteLine("Printing with Alignment");
Console.WriteLine();
DocumentManager.getInstance().getBook().print();

