class SpaceAge:
    def __init__(self, seconds):
        self.earth_year = seconds / 31557600
        self.space_factors = {
            "earth" : 1,
            "mercury" : 0.2408467,
            "venus" : 0.61519726,
            "mars" : 1.8808158,
            "jupiter" : 11.862615,
            "saturn" : 29.447498,
            "uranus" : 84.016846,
            "neptune" : 164.79132
        }

    def calculate_age_on_planet(self, planet):
        return round((self.earth_year / self.space_factors[planet]), 2)

    def on_earth(self):
        return self.calculate_age_on_planet('earth')

    def on_mercury(self):
        return self.calculate_age_on_planet('mercury')

    def on_venus(self):
        return self.calculate_age_on_planet('venus')

    def on_mars(self):
        return self.calculate_age_on_planet('mars')

    def on_jupiter(self):
        return self.calculate_age_on_planet('jupiter')

    def on_saturn(self):
        return self.calculate_age_on_planet('saturn')

    def on_uranus(self):
        return self.calculate_age_on_planet('uranus')

    def on_neptune(self):
        return self.calculate_age_on_planet('neptune')

    