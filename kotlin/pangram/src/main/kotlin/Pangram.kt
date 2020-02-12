object Pangram {

    fun isPangram(input: String): Boolean {
       return ('a'..'z').all{ x -> input.contains(x, ignoreCase = true) }
    }
}
