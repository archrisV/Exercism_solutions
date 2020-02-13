import datetime

def add(moment: datetime) -> datetime:
    return moment + datetime.timedelta(0, 1e9)
