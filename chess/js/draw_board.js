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
        for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                    {            
                        if (i % 2 == 0)
                            {
                                if (j % 2 == 0)    
                                {
                                    context.beginPath();
                                    context.moveTo(0, 0);
                                    context.lineTo(0, 100);
                                    context.lineTo(100, 100);
                                    context.lineTo(100, 0);
                                    context.lineTo(0, 0);
                                    context.fill ();
                                }
                                else
                                    {
                                    context.beginPath();
                                    context.moveTo(0, 0);
                                    context.lineTo(0, 100);
                                    context.lineTo(100, 100);
                                    context.lineTo(100, 0);
                                    context.lineTo(0, 0);
                                    context.stroke();    
                                    }
                            }
                            else
                                {
                                    if (j % 2 == 0)    
                                {
                                    context.beginPath();
                                    context.moveTo(0, 0);
                                    context.lineTo(0, 100);
                                    context.lineTo(100, 100);
                                    context.lineTo(100, 0);
                                    context.lineTo(0, 0);
                                    context.stroke ();
                                }
                                else
                                    {
                                    context.beginPath();
                                    context.moveTo(0, 0);
                                    context.lineTo(0, 100);
                                    context.lineTo(100, 100);
                                    context.lineTo(100, 0);
                                    context.lineTo(0, 0);
                                    context.fill();    
                                    }
                                }
                    }
            }
}
