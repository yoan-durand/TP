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
    function clic(e)
    {
    mouseX = e.clientX + document.body.scrollLeft + document.documentElement.scrollLeft;
    mouseY = e.clientY + document.body.scrollTop + document.documentElement.scrollTop;

    context.fillStyle= "blue";
    context.fillRect((mouseX/100) * 100, (mouseY/100) * 100, 100,100);
    }
    document.onclick = clic;
}

