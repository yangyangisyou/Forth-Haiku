: y x t 2 / 10.2 3 / mod - 15 * 0.15 cos * cos 50 / y + 0.005 + ;
: n 7 ; \ number of spikes
: alpha pi 10 / ; \ half of spike angle
: x0 0.5 ; ( 太陽x座標 )
: y0 0.5 ; ( 太陽y座標 )
: r0 0.15 ; 
: theta x x0 - y y0 - atan2 pi + ; ( 太陽的角度 )
: r x x0 - dup * y y0 - dup * + sqrt ; ( 半徑 )
: beta theta pi n / 2 * mod pi n / - abs ; ( 太陽尖尖 )
: b r0 alpha sin * alpha cos beta sin * beta cos alpha sin * + / ; ( 呈現太陽尖尖狀 )

0
b r > r 0.1 > and r 0.09 < or or 
\ 太陽圖形 + 紅色
x 0.5 < y 0.5 < y 0.99 < y 0.025 > and and and x 0.5 > y 0.5 > y 0.995 < and and or b r > r 0.1 > and r 0.09 < or b r > r 0.1 > and r 0.09 < or x 0.5 > y 0.5 < and and or or \ 綠
b r > r 0.1 > and r 0.09 < or x 0.5 < y 0.5 > y 0.995 < and and x 0.5 > y 0.5 < y 0.025 > and and or or \ 藍
y 0.025 > y 0.975 < and
