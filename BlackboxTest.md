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

Test to pass:             Utfall:            Kommentar:                 
Alla lika:

    0.0 0.0 0.0
    1.5 1.5 1.5
    
två lika:

    3.0 3.0 1.0
    2.4 1.8 2.4
    4.0 2.0 2.0
    
Olika:

    8.6 4.3 2.5
    9.9 0.1 3.9
    
    4.0 5.0 1.0
    2.4 3.1 2.5
    
    1.5 2.5 3.0
    3.0 2.0 3.5
    

Test to fail:

    -0.5 -0.5 -1.0
    2.0 -2.0 2.0
    -4.9 3.3 7.0
    99999999999.999999999999999999999.9999999999 99999999999.9999999999
    
Upprepa: (tills nöjd)

Analysera ev. felaktigheter och sammanfatta i din testrapport:
===========================
