public class BowlingGame
{
    private int[] rolls = new int[22];
    private int currentRoll;

    public void Roll(int pins)
    {
        rolls[currentRoll] = pins;
        currentRoll++;
    }

    public int Score(){
        int score = 0;
        int roll = 0;
        // 10 frames.
        for(int i = 0; i < 10; i++){
            if(IsStrike(roll)){
                score += SumStrike(roll);
                roll++;
            }
            if(IsSpare(roll)){
                score += SumSpare(roll);
                roll += 2;
            }
            else{
                score += SumNoBonus(roll);
                roll += 2;
            }
        }

        return score;
    }

    private int SumStrike(int roll){
        return 10 + rolls[roll + 1] + rolls[roll + 2];
    }

    private int SumSpare(int roll){
        return 10 + rolls[roll + 2];
    }

    private int SumNoBonus(int roll){
        return rolls[roll] + rolls[roll + 1];
    }

    private bool IsStrike(int roll){
        return rolls[roll] == 10;
    }

    private bool IsSpare(int roll){
        return rolls[roll] + rolls[roll + 1] == 10;
    }
}
