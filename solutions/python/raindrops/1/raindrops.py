def convert(number):
    soundComb = ""
    soundList = ["Pling","Plang","Plong"]
    if number % 3 == 0:
        soundComb += "Pling"
    if number % 5 == 0:
        soundComb += "Plang"
    if number % 7 == 0:
        soundComb += "Plong"
    if any(sound in soundComb for sound in soundList):
        return soundComb
    return f"{number}"
