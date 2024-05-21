import random

# Generate a random number between 1 and 10
random_number = random.randint(1, 10)

# Print the random number
print("Random number:", random_number)


print("Hello, World!")

for num in range(1, 101):
    if num % 3 == 0 and num % 5 == 0:
        print("FuzzyBuzz")
    elif num % 3 == 0:
        print("Fuzzy")
    elif num % 5 == 0:
        print("Larisse")
    else:
        print(num)