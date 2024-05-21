print("Hello, World!")

for num in range(1, 101):
    if num % 3 == 0 and num % 5 == 0:
        print("FuzzyBuzz")
    elif num % 3 == 0:
        print("Fuzzy")
    elif num % 5 == 0:
        print("Buzz")
    else:
        print(num)