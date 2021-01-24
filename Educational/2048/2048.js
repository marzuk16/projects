var map = [[0,0,0,0],[0,0,0,0],[0,0,0,0],[0,0,0,0]], i, j, k = 0, output, score = 0;
//const scoreElement = document.getElementById("score");
//scoreElement.innerHTML = score;

function main(){
	
    initialise();
    display();
}


function initialise(){
	
    output = document.getElementsByClassName("cell");
    placerandom(2);
}

function display(){
    k=0;
    for(i=0; i<4; i++){
        for(j=0; j<4; j++){
            if( !map[i][j]){
				
                output[k].style.background="#e6e6e6";
				output[k].innerHTML=null;
				k++;
            }
			else{
				
               var el = output[k].cloneNode(true);
               output[k].parentNode.replaceChild(el, output[k]);
               output[k].style.background = colour();
               output[k].innerHTML = map[i][j];
			   k++;
            }
        }
    }
}
 
function play(n){
    var flag = false;
    switch(n){
		case 1:
		for(i=1; i<4; i++){
			for(j=0; j<4; j++){
				k = i;
				if(map[i][j]){
					while( (k>0) && ( !map[k-1][j] || (map[k-1][j] == map[k][j]) ) ){
						if( !map[k-1][j]){
							map[k-1][j] = map[k][j];
							map[k][j] = 0;
							flag = true;
						}
						else{
							map[k-1][j] *= 2;
							map[k][j] = 0;
							flag = true;
							break;
						}
						k--;
					}
                }
            }
        }
    
		if( !flag){
			gameover();
			break;
		}
		placerandom(2);
		display();
		break;
		
		case 2:
		for(j=1; j<4; j++){
			for(i=0; i<4; i++){
				k = j;
				if( map[i][j]){
					while( (k>0) && ( !map[i][k-1] || (map[i][k-1] == map[i][k]) ) ){
						if( !map[i][k-1]){
							map[i][k-1] = map[i][k];
							map[i][k] = 0;
							flag = true;
						}
						else{
							map[i][k-1] *= 2;
							map[i][k] = 0;
							flag = true;
							break;
						}
						k--;
					}
				}
			}
		}
		if( !flag){
			gameover();
			break;
		}
		placerandom(2);
		display();
		break;
		
		case 3:
		for(j=3; j>=0; j--){
			for(i=0; i<4; i++){
				k = j;
				if( map[i][j]){
					while( (k<3) && ( !map[i][k+1] || (map[i][k+1] == map[i][k]) ) ){
						if( !map[i][k+1]){
							map[i][k+1] = map[i][k];
							map[i][k] = 0;
							flag = true;
						}
						else{
							map[i][k+1] *= 2;
							map[i][k] = 0;
							flag = true;
							break;
						}
						k++;
					}
				}
			}
		}
		if( !flag){
			gameover();
			break;
		}
		placerandom(2);
		display();
		break;
		
		case 4:
		for(i=3; i>=0; i--){
			for(j=0; j<4; j++){
				k = i;
				if(map[i][j]){
					while( (k<3) && ( !map[k+1][j] || (map[k+1][j] == map[k][j]))){
						if( !map[k+1][j]){
							map[k+1][j] = map[k][j];
							map[k][j] = 0;
							flag = true;
						}
						else{
							map[k+1][j] *= 2;
							map[k][j] = 0;
							flag = true;
							break;
						}
						k++;
					}
				}
			}
		}
		if( !flag){
			gameover();
			break;
		}
		placerandom(2);
		display();
		break;
    }
}

function gameover(){
	
    if( !emptycells()){
        alert("|GAME OVER|");
    }
}

function placerandom(n){
	
	k = Math.floor((Math.random()*emptycells())+1);
	
    for(i=0; i<4; i++){
        for(j=0; j<4; j++){
            if( !map[i][j]){
                k--;
            }
			
            if( !k){
                break;
            }
        }
        if( !k){
			break;
        }
    }
	
    map[i][j] = n;        
}

function emptycells(){
	
	cnt = 0;
    for(i=0; i<4; i++){
        for(j=0; j<4; j++){
            if( !map[i][j]){
                cnt++;
            }
        }
    }
	
    return cnt;
}

function colour(){
	
	var color = ["#b3b3ff", "#ff9999", "#ff944d", "#e65c00", "#992600", "#e60000", "#006600", "#e6e600", "#1a1aff", "#001a66"];
	var ind = Math.log2(map[i][j]);
	
	return color[ind-1];
}