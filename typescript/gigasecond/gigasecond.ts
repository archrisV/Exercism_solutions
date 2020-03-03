class Gigasecond{
    dateGigasecond: Date;
    constructor(inputDate: Date){
        this.dateGigasecond = new Date(inputDate.getTime() + 1e12);
    }
    date(): Date{
        return this.dateGigasecond;
    }
}

export default Gigasecond