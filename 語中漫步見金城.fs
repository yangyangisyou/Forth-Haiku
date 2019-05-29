: 閃耀星星 >r 1024 / 1 swap - y - abs swap 1024 / x - abs + 20 * 0.3 ** r> ** 1 - negate 20 * t 10 * x y + 10 * + sin 1.5 + 3 / * ;
: ! max ;
: c 256 / * ;
: 雨從天降 
x .5 - dup * y .0 - dup * + sqrt ;
: 閃亮晶晶
x y ** 90 * sin t sqrt 100 / *
40 swap * dup swap floor -
1000 * 999 - 0 max
;
: g dup x pi * * cos abs .992 >
swap y pi * * cos abs .992 >
or ; 19 g
: f ( n y -- ) swap 2dup 19 /
> -rot 1 + 19 / < and ;
: h ( y -- ) y f or ; 0 h 18 h
: v ( x -- ) x f or ; 0 v 18 v
: p ( x y -- )
y f swap x f and or ; \ 3 5 p
: 橫 ( x y n -- ) swap ( x n y )
y over 19 / > ( x n y f )
y rot 1 + 19 / < and ( x n f )
-rot ( x f n ) >r ( f x ) 
x over 19 / > ( f x f ) x rot
r> + 19 / < ( f f f )
and and or ;
: 直 ( x y n -- ) rot ( y n x )
x over 19 / > ( y n x f )
x rot 1 + 19 / < and ( y n f )
-rot ( y f n ) >r ( f y )
y over 19 / > ( f x f ) y rot
r> + 19 / < ( f f f )
and and or ;
: 城城是你 
2 6 3 橫 2 8 3 橫
3 6 4 直 
6 4 1 直
7 11 9 橫 7 8 3 橫 7 4 8 直
10 6 3 直
13 4 10 直 
14 4 1 橫
15 13 1 橫
12 6 1 橫
14 6 1 橫
;

0 
城城是你 閃亮晶晶 
( 閃耀星星的亮點 )
0
320 160 .1 閃耀星星 250 c !
590 520 .1 閃耀星星 250 c !
100 700 .1 閃耀星星 250 c !
880 270 .1 閃耀星星 250 c !
820 800 .1 閃耀星星 250 c !
+ + 

dup
rot
t sin 5 / 0.9 + 
y t + x 0.2 + mod - 
( Reference from Orion Blink , chinese 中 , 彩虹雨 , 星際透視鐘 )
