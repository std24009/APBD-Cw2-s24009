# APBD-Cw2-s24009

Modele sprzętów i użytkowników korzystają z dziedziczenia, co pozwoli stworzyć bazę pod kolejne, specyficzne rozszerzenia klasy.

W systemie rezerwacji korzystamy z interfejsów, dzięki czemu możemy je podpinać do nowy klas, jak klocki Lego.
Działa tutaj zasada segregacji interfejsów. Każdy interfejs specjalizuje się w konkretnej roli.

W pliku odpowiedzialnym za obsługę została zastosowana zasada podstawienia Liskov, gdzie została stworzona lista typu bazowego dla przedmiotów, ale możemy w niej umieścić
elementy, które dziedziczą po tej klasie.