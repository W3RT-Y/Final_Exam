a, b = 0, 1
i = 0

while i < 100:
       result = a + b
       a = b
       b = result
       i += 1
       if a<1000:
        print(a)
       else:
           continue
