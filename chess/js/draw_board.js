/* 
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
window.onload = function ()
{
    var canvas = document.getElementById('mon_canvas');
    
    
        if (!canvas)
            {
                alert("impossible de recuperer le canvas");
                return;
            }
         
     
    
    
    var context = canvas.getContext('2d');
    if (!context)
        {
            alert ("impossible de recupere le context canvas");
            return;
        }      
        var i = 0;
        var j = 0;
        var mouseX = 0;
        var mouseY = 0;
        for (i = 0; i < 8; i++)
            {
                for (j = 0; j < 8; j++)
                    {            
                        if (i % 2 == 0)
                            {
                                if (j % 2 == 0)    
                                {
                                    context.beginPath();
                                    context.lineTo(((j+1)*100), (i*100));
                                    context.lineTo(((j+1)*100) , ((i+1) * 100));
                                    context.lineTo((j*100), (100*(i+1)));                               
                                    context.lineTo((j * 100), (i*100));
                                    context.fill ();
                                    context.closePath();
                                    
                                }
                            
                                else
                                    {
                                    context.beginPath();
                                    context.lineTo(((j+1)*100), (i*100));
                                    context.lineTo(((j+1)*100) , ((i+1) * 100));
                                    context.lineTo((j*100), (100*(i+1)));                               
                                    context.lineTo((j * 100), (i*100));
                                    context.stroke ();
                                    context.closePath();    
                                    }
                            }
                            else
                                {
                                    if (j % 2 == 0)    
                                {
                                    context.beginPath();
                                    context.lineTo(((j+1)*100), (i*100));
                                    context.lineTo(((j+1)*100) , ((i+1) * 100));
                                    context.lineTo((j*100), (100*(i+1)));                               
                                    context.lineTo((j * 100), (i*100));
                                    context.stroke ();
                                    context.closePath();
                                }
                                else
                                    {
                                    context.beginPath();
                                    context.lineTo(((j+1)*100), (i*100));
                                    context.lineTo(((j+1)*100) , ((i+1) * 100));
                                    context.lineTo((j*100), (100*(i+1)));                               
                                    context.lineTo((j * 100), (i*100));
                                    context.fill ();
                                    context.closePath();    
                                    }
                                }
                    }
            }
            var select = false;
            var ancientX = 0;
            var ancientY = 0;
    
    
        var qw = new Image ();
        qw.onload = function()
        {
            context.drawImage(qw, 400, 0, 100, 100);
            context.moveTo(400, 0);
            context.lineTo(500, 0);
            context.lineTo(500, 100);
            context.lineTo(400, 100);
            context.lineTo(400, 0);
            context.stroke();
        }
        qw.src = '../image/whitequeen.png';
            
    function clic(e)
    {
        if (select)
        {
            var x = ancientX / 100;
            var y = ancientY / 100;
                        
            context.clearRect(ancientX, ancientY, 100, 100);
            
            if (x % 2 == 0)
                {
                    if (y % 2 == 0)
                        {
                            context.fillStyle = "black";
                            context.fillRect(ancientX, ancientY, 100, 100);
                        }
                        else
                            {
                                context.strokeStyle = "black";
                                context.strokeRect(ancientX, ancientY, 100, 100);
                            }
                            
                }
                else
                    {
                        if (y % 2 == 0)
                            {
                                context.strokeStyle = "black";
                                context.strokeRect(ancientX, ancientY, 100, 100);
                            }
                            else
                                {
                                    context.fillStyle = "black";
                                    context.fillRect(ancientX, ancientY, 100, 100);
                                }
                    }
            select = false;
            
        }
            mouseX = e.clientX ;
            mouseY = e.clientY ;
            while (mouseX % 100 != 0)
                {
                    mouseX--;
                }
            while (mouseY % 100 != 0)
                {
                    mouseY--;
                }
                ancientX = mouseX;
                ancientY = mouseY;
            context.fillStyle= "rgba(0, 0, 255, 0.5)";
            context.fillRect(mouseX, mouseY, 100, 100);
            select = true;
       } 
    document.onclick = clic;
    
    
    
}   

