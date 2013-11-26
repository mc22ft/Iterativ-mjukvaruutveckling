Blackbox Test Triangle
===========================


"ekvivalensklass test"

#Krav:
Det ska skickas in tre decimal tal. Och ut ska man få resultatet av en triangel, liksidig eller likbent. Eller 
om den inte har några lika sidor alls.

#Information:
Programmet triangel.exe läser in tre sidor hos en giltig triangel och avgör om den är liksidig (Equilateral),
likbent (Isosceles) eller om den inte har några lika sidor (Scalene). Sidorna anges som decimaltal (double) på
kommandoraden. Programmet skriver ut vilken typ av triangel sidorna bildar. 

#Exempel:

    Skickar in: 2.0 2.0 2.0
    är liksidig
    Skickar in: 3.0 3.0 2.0
    är likbent

#Förnuft: (hur systemet ska bete sig)
Man ska få ett få ett svar att triangeln är liksidig eller likbent el inga sidor lika alls. Det är den 
informationen jag har nu innan.

Dynamsisk testning - indatan matas in.
===========================
TestFall med förväntat resultat. (pass/fail)

    Test to pass:         Förväntat Utfall:             Resultat/Kommentar:                 
    
    Alla lika:

    0.0 0.0 0.0           Pass                          Liksidig, förväntat resultat.
    1.5 1.5 1.5           Pass                          Liksidig, förväntat resultat.
    
    två lika:

    3.0 3.0 1.0           Pass                          Likbent, förväntat resultat.
    2.4 1.8 2.4           Pass                          Likbent, förväntat resultat.
    4.0 2.0 2.0           Pass                          Likbent, förväntat resultat.
    
    Olika:

    8.6 4.3 2.5           Pass                          Inga lika sidor, förväntat resultat.
    9.9 0.1 3.9           Pass                          Inga lika sidor, förväntat resultat.
    
    4.0 5.0 1.0           Pass                          Inga lika sidor, förväntat resultat.
    2.4 3.1 2.5           Pass                          Likbent, oväntat resultat.
    
    1.5 2.5 3.0           Pass                          Inga lika sidor, förväntat resultat.
    3.0 2.0 3.5           Pass                          Likbent, oväntat resultat.
    

    Test to fail:

    -0.5 -0.5 -1.0        Fail                          Likbent, oväntat resultat.
    2.0 -2.0 2.0          Fail                          Likbent, oväntat resultat.
    -4.9 3.3 7.0          Fail                          Inga lika sidor, oväntat resultat-
    99999999999.9999999999 99999999999.9999999999 99999999999.9999999999     Fail  Unhandled Exception, förväntat resultat.  
    
Upprepa: (tills nöjd)

Analysera ev. felaktigheter och sammanfatta i din testrapport:
===========================
