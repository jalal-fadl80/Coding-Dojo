from random import randint
num = input('Number of times to flip coin: ')
flips = [randint(0,1) for r in range(num)]
resultsheads = []
resultstails = []
heads = 0
tails = 0
for object in flips:
        if object == 0:
            resultsheads.append('Heads')
            heads = heads + 1
        elif object == 1:
            resultstails.append('Tails')
            tails = tails + 1
print heads
print resultsheads
print tails
print resultstails
