import java.lang.*;
class IsogramChecker {

    boolean isIsogram(String phrase) {
        var lowercasePhrase = phrase.toLowerCase();
        for(char letter : lowercasePhrase.toCharArray()){
            if(Character.isLetter(letter) && lowercasePhrase.indexOf(letter) != lowercasePhrase.lastIndexOf(letter)){
                return false;
            }
        }
        return true;
    }

}
