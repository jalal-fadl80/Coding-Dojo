function slots (nQuarters){

    while (nQuarters > 0) { //this part is asking us to do the following while the player still has quarters left

        var isWin = ((100 * Math.random()) < 1); //this part is determining the outcome of a 1 in 100 win. you multiply it by 100 becayse math.random gives you a number 0 and not quite 1. and then you compare it to be less than one for the 1 percent chance of winning

                                                    //console.log(isWin); //this is to see if they won or not and to count wins and losses for my own benefit to help me keep track, it reutnrs false or a win value.

        var winAmount = (50 + Math.floor(Math.random() * 50)); //this part is determing the number of quarters they get back from the game when they win. you multiply 50 by math.random to get a number between 0 and 50, then you add 50, and use math.floor to make all numbers into integers

        nQuarters--; //you decrease the amount of quarters by one, because they used one quarter to play the game

        if (isWin){

            return nQuarters + winAmount; //you use this and if to return the amout of quarters left if they won.

        }

    }//loop back around to while until out of quarters

    return 0; // you return 0 if they spent all their quarters and never won once

}
