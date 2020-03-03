class Hamming {
    private String left;
    private String right;

    Hamming(String leftStrand, String rightStrand) {
        if(leftStrand == null || (leftStrand == "" && rightStrand.length() != 0)){
            throw new IllegalArgumentException("left strand must not be empty.");
        }
        if(rightStrand == null || (rightStrand == "" && leftStrand.length() != 0)){
            throw new IllegalArgumentException("right strand must not be empty.");
        }
        if(leftStrand.length() != rightStrand.length()){
            throw new IllegalArgumentException("leftStrand and rightStrand must be of equal length.");
        }
        left = leftStrand;
        right = rightStrand;
    }

    int getHammingDistance() {
        int distance = 0;
        for(int i = 0; i < left.length(); i++ ){
            if(left.charAt(i) != right.charAt(i)) distance++;
        }
        return distance;
    }

}
