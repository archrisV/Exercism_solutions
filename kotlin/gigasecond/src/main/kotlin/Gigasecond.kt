import java.time.LocalDateTime
import java.time.LocalDate

class Gigasecond (time: LocalDateTime){
    constructor(time: LocalDate) : this(time.atStartOfDay())
    val date: LocalDateTime = time.plusSeconds(1_000_000_000);
}
