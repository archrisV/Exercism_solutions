import java.time.LocalDate;
import java.time.LocalDateTime;

class Gigasecond {
    private final LocalDateTime gigasecondTime;

    Gigasecond(LocalDate moment) {
       gigasecondTime = moment.atStartOfDay().plusSeconds(1_000_000_000);
    }

    Gigasecond(LocalDateTime moment) {
        gigasecondTime = moment.plusSeconds(1_000_000_000);
    }

    LocalDateTime getDateTime() {
        return this.gigasecondTime;
    }

}
