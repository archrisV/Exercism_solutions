import java.util.HashMap;

class Scrabble {

    private final String word;
    private static final HashMap<Integer, Integer> letterValueMap = new HashMap<>();

    public Scrabble(String word) {
        addLettersToMap("AEIOULNRST", 1);
        addLettersToMap("DG", 2);
        addLettersToMap("BCMP", 3);
        addLettersToMap("FHVWY", 4);
        addLettersToMap("K", 5);
        addLettersToMap("JX", 8);
        addLettersToMap("QZ", 10);
        this.word = word.toUpperCase();
    }

    public int getScore() {
        return this.word.chars()
                .map(character -> letterValueMap.getOrDefault(character, 0))
                .reduce(0, (x, y) -> x + y);
    }

    private static void addLettersToMap(String letters, Integer value) {
        letters.chars().forEach(letter -> letterValueMap.put(letter, value));
    }

}
