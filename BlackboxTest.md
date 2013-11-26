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
    
Upprepning 1 (upprepa tills nöjd)

    2.0 1.0 3.0           Fail                          Inga lika sidor, oväntat resultat. Trodde på likbent.              
    5.5 1.5 8.0           Fail                          Inga lika sidor, oväntat resultat. Trodde på likbent.  
    -4.0 -2.0 -6.0        Fail                          Inga lika sidor, oväntat resultat. Trodde på likbent.  

Upprepning 2

    2.0 2.5 5.0           Fail                          Likbent, förväntat resultat. Rätt ska va inga lika sidor. 
    6.1 6.9 3.4           Fail                          Likbent, förväntat resultat. Rätt ska va inga lika sidor. 
    4.3 4.4 6.0           Fail                          Likbent, förväntat resultat. Rätt ska va inga lika sidor. 

Upprepning 3

    4.5 4.6 4.7           Fail                          Liksidig, oväntat resultat. Rätt ska va inga lika sidor. 

Analysera ev. felaktigheter och sammanfatta i din testrapport:
===========================

Efter mina tester av Trinagel.exe. Kan jag märka en bugg i systemet. Men jag böjar med mitt test på rad 61. Där jag 
la in 10st 9 komma/punkt 10st 9 igen. För att testa programmets kapacitet. Jag fick ett Unhadled exeption på det. La
inte mer tid för tester på det. Det rätta i detta läget är att titta i systemet på hur mycket man kan mata in. Jag la
inte heller mer tid på negativa tal då jag märker att systemet hanterar dessa samma som poseriva tal.

Buggen som jag upptäkte först var på rad 50 och 53. Då jag skulle ha haft olika sidor på triangeln men fick likbent på 
båda av dessa. Efter lite analys av inskickat värde misstänkte jag att det var något med ordningen. Att i mina tester
hade jag det mellersta värdet först. Testade på nytt, utan resultat. Analyserade på nytt. Såg att det var två av 
värderna som var på samma heltal. Testade på detta i upprepning 2. Konstaterade att detta var det som var fel. Systemet
läser inte av decimal tal. Utan läser bara av första talet av värdet. 
Jag gjorde ett sista test. Skickade in 3 olika fast inom samma heltal. Fick som förväntat ut en liksidig triangel. Detta
gjorde mig mer säker på att jag hade rätt.

