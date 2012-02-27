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
                                    context.fillStyle="springgreen";
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
                                    context.fillStyle= "seagreen";
                                    context.fill();
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
                                    context.fillStyle= "seagreen";
                                    context.fill();
                                    context.closePath();
                                }
                                else
                                    {
                                    context.beginPath();
                                    context.lineTo(((j+1)*100), (i*100));
                                    context.lineTo(((j+1)*100) , ((i+1) * 100));
                                    context.lineTo((j*100), (100*(i+1)));                               
                                    context.lineTo((j * 100), (i*100));
                                    context.fillStyle="springgreen";
                                    context.fill ();
                                    context.closePath();    
                                    }
                                }
                    }
            }
            var select = false;
            var ancientX = 0;
            var ancientY = 0;
    
    
        
            
    function clic(e)
    {
        if (select && drawpiece )
        {
            var x = ancientX / 100;
            var y = ancientY / 100;
                       
            
            if (x % 2 == 0)
                {
                    if (y % 2 == 0)
                        {
                            context.fillStyle = "springgreen";
                            context.fillRect(ancientX, ancientY, 100, 100);
                        }
                        else
                            {
                                context.fillStyle = "seagreen";
                                context.fillRect(ancientX, ancientY, 100, 100);
                            }
                            
                }
                else
                    {
                        if (y % 2 == 0)
                            {
                                context.fillStyle = "seagreen";
                                context.fillRect(ancientX, ancientY, 100, 100);
                            }
                            else
                                {
                                    context.fillStyle = "springgreen";
                                    context.fillRect(ancientX, ancientY, 100, 100);
                                }
                    }
            select = false;
            
            
        }
            drawpiece = true;
            mouseX = e.clientX ;
            mouseY = e.clientY + document.body.scrollTop + document.documentElement.scrollTop;
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
            context.fillStyle= "rgba(255, 0, 255, 0.5)";
            context.fillRect(mouseX, mouseY, 100, 100);
            select = true;
            ajax ();
       } 
    document.onclick = clic;
   
        var qw = new Image ();
        qw.onload = function()
        {
            context.drawImage(qw, 300, 0, 100, 100);
            
        }
        qw.src = '../image/wQ.png';
       

       var tw1 = new Image ();   
       tw1.onload = function ()
       {
           context.drawImage(tw1, 0, 0, 100, 100);
           context.drawImage(tw1, 700, 0, 100, 100);
       }
        tw1.src = '../image/wT.png';       

        var nw =  new Image ();
        nw.onload = function () 
       {
           context.drawImage(nw, 100, 0, 100, 100);
           context.drawImage(nw, 600, 0, 100, 100);
       }
       nw.src = '../image/wN.png';
    
       var bw = new Image ();
       bw.onload = function ()
       {
			context.drawImage(bw, 200, 0, 100, 100);
                        context.drawImage(bw, 500, 0, 100, 100);
       }
	   bw.src = '../image/wB.png';
        
        var kw = new Image ();
        kw.onload = function ()
            {
                    context.drawImage (kw, 400, 0, 100, 100);
            }
        kw.src = '../image/wK.png';
    
    var pw = new Image ();
    pw.onload = function ()
    {
        var i =0;
        for (i = 0; i < 8; i++)
        {
            context.drawImage(pw, i * 100, 100, 100, 100);
        }
    }
    pw.src = '../image/wP.png';
   
   var qb = new Image ();
        qb.onload = function()
        {
            context.drawImage(qb, 300, 700, 100, 100);
            
        }
        qb.src = '../image/bQ.png';
       
       
       var tb = new Image ();
       
       tb.onload = function ()
       {
           context.drawImage(tb, 0, 700, 100, 100);
            context.drawImage(tb, 700, 700, 100, 100);
       }
        tb.src = '../image/bT.png';
       
        var nb =  new Image ();
        
       nb.onload = function () 
       {
           context.drawImage(nb, 100, 700, 100, 100);
           context.drawImage(nb, 600, 700, 100, 100);
       }
       nb.src = '../image/bN.png';

        var bb = new Image ();
       bb.onload = function ()
       {
            context.drawImage(bb, 200, 700, 100, 100);
            context.drawImage(bb, 500, 700, 100, 100);
       }
	   bb.src = '../image/bB.png';

        var kb = new Image ();
	  kw.onload = function ()
		{
			context.drawImage (kb, 400, 700, 100, 100);
		}
	  kb.src = '../image/nK.png';
    
    var pb = new Image ();
    pb.onload = function ()
    {
        var i2 = 0;
        for (i2 = 0; i2 < 8; i2++)
            {
                context.drawImage(pb, i2 * 100, 600, 100, 100);
            }       
    }
    pb.src = '../image/nP.png';



    ///Code AJAX pour interagir avec PHP
    function ajax (){
    var xhr = new XMLHttpRequest();
    var mx = (mouseX/100);
    var my = (mouseY/100 );
   // alert ('avant state');
    xhr.onreadystatechange = function() { // On gère ici une requête asynchrone
        if (xhr.readyState == 4 && xhr.status == 200) {
            alert (xhr.responseText);
            var json = eval('('+xhr.responseText+')');
            //alert ('appel colorcase');
            colorcase(json);
        }

    };
        xhr.open("GET", "http://chess.local/ajax.php?mx="+mx+"&my="+my, true);
    xhr.send(null);
    }
    var drawpiece = true;
    
    function colorcase(tablo)
    {
       // alert ('colorcase');
        var i = 0;
    if (tablo[tablo.length - 1]>= "A" && tablo[tablo.length - 1] <= "Z")
        {
            xtab = tablo[0];
            ytab = tablo[1];
           switch (tablo[3])
           {
               case 'White':
                        switch (tablo[2])
                        {
                            case 'P':
                                context.drawImage(pw, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'T':
                                context.drawImage(tw1, 100 * tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'B':
                                context.drawImage(bw, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'N':
                                context.drawImage(nw, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'Q':
                                context.drawImage(qw, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'K':
                                context.drawImage(kw, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                    }
                    break;
                    
               case 'Black':
                   switch (tablo[2])
                        {
                            case 'P':
                                context.drawImage(pb, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'T':
                                context.drawImage(tb1, 100 * tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'B':
                                context.drawImage(bb, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'N':
                                context.drawImage(nb, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'Q':
                                context.drawImage(qb, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                            case 'K':
                                context.drawImage(kb, 100*tablo[0], 100*tablo[1], 100, 100);
                                drawpiece = false;
                                break;
                    }
                    break;
                   break;
                   
                
           }
        }
        else
        {        
            for (i = 0; i < tablo.length; i++)
                {
                    if (i % 2 == 0)
                        {
                            context.fillStyle= "rgba(255,0,255,0.5)";
                            context.fillRect(tablo[i]*100, tablo[i+1]*100, 100, 100);
                        }
                }
        }
    }   




}
   

