# IneoNupkg

Zadanie polega na napisaniu windowsowej aplikacji konsolowej (Visual Studio + C#), która będzie przyjmować na wejściu ścieżkę do katalogu z paczkami NuGet oraz wypisze na ekranie listę najnowszych paczek w podanym katalogu. Algorytm sortujący paczki powinien być zgodny z tym używanym przez system NuGet.
Kod powinien być pisany zgodnie z zasadami programowania obiektowego, zasadą pojedynczej odpowiedzialności i innymi zasadami. Klasy nie muszą znajdować się w oddzielnych plikach.

Założenia:
• Paczki mają zawsze rozszerzenie *.nupkg
• Nazwa paczki składa się z 2 lub 3 elementów oddzielonych kropkami:
o Identyfikatora w postaci ciągów znaków z alfabetu łacińskiego (xxx)
o Numeru wersji w postaci 3 lub 4 liczb całkowitych oddzielonych kropkami (d.dd.d, d.dd.dd.d)
o Opcjonalnego suffixu składającego się z myślnika i ciągu znaków alfanumerycznych (-xxx123)
• Identyfikator nie zawiera kropki (co jest uproszczeniem względem systemu NuGet)
• Paczki z wyższym numerem wersji są traktowane jako nowsze
• Paczki z tym samym numerem wersji ale bez suffixu są traktowane jako nowsze
• Paczki z tym samym numerem wersji są nowsze jeśli ich suffix jest późniejszy w sortowaniu leksykograficznym
