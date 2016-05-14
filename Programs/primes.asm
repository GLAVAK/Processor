load 30 % (20)+=2:
add 35
save 30
save 31 % check is (20) a prime
goto 6
load 31
sub 34
sub 34
goto 11
load 34 % load 1 to force 7.goto to work
goto 18 % we checked all divisors, and it's prime
add 34
save 31
load 30
mod 31
goto 5 % it doesn't dividing, continue checking
load 34
goto 0 % it does, it's not prime, try next number
load 33
sub 34
save 33
goto 0 % it's not ours number yet, start over with next number
load 30
print






const 1 % Current number
const 1 % Current divisior

const 4 % Number of prime number we want to get
const 1 % constant
const 2 % constant