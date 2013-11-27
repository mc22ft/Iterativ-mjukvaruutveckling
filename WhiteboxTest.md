Whitebox Test Triangel
===========================

Analys:

    Första analys av koden ser jag en struct, Point som tar två int. Jag kan även se att två av konstruktorna i Triangel      klassen anropar Point. Detta återkommer jag till. Det finns även tre metoder för varje modell av triangel som ska va      möjligt att få ut. Alla av dessa tre kan returnera true eller false. 
    
    En snabb slutsats så tänker jag att felet som finns från blackox testet finns i structen point. Men då jag har set i      koden och testat lite så vet jag att den kan även ta double. Så mitt test i blackbox att programet inte kan ta ett        decemal tal stämmer inte.
    
Slut Analys:

    Då jag testat metoderna och analyserat koden. Och genom tester set hur programet beter sig. Kan jag se i mina             "standard" tester att koden inte är rätt. Och jag har kontrollerat min tidigare misstanke om att koden inte kunde         hantera decemal tal. Då jag får resultatet från mina tester så vet jag sen innan att det måste vara fel på                uträkningen. Källa: Att det kan va bra att kunna Pythagoras sats och lite om det tvådimensionella Kartesiska              koordinatsystemet från uppgift beskrinvningen. Och detta kan jag se då testerna visar false när det ska va true och       vise varse.
