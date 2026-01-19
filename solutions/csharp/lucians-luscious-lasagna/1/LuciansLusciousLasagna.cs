class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){

        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutosPasados){

        return ExpectedMinutesInOven() - minutosPasados;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int capasLasagna){

        return capasLasagna * 2;
    }
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int capasLasagna,int minutosHorneandose){
        
        return PreparationTimeInMinutes(capasLasagna)+minutosHorneandose;
    }
}
