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
        if (select)
        {
            var x = ancientX / 100;
            var y = ancientY / 100;
                        
            context.clearRect(ancientX, ancientY, 100, 100);
            
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
            context.fillStyle= "rgba(0, 0, 255, 0.5)";
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
        var imtab = new array(qw); 

       var tw1 = new Image ();   
       tw1.onload = function ()
       {
           context.drawImage(tw1, 0, 0, 100, 100);
       }
        tw1.src = '../image/wT.png';
        imtab.push(tw1);
       var tw1 = new Image ();
       
       tw2.onload = function ()
       {
          context.drawImage(tw2, 700, 0, 100, 100);
       }
        tw2.src = '../image/wT.png';  
        imtab.push(tw2);           

        var nw =  new Image ();
        nw.onload = function () 
       {
           context.drawImage(nw, 100, 0, 100, 100);
       }
       nw.src = '../image/wN.png';

       imtab.push(nw);
       
        var nw1 =  new Image ();
        nw1.onload = function () 
       {
           context.drawImage(nw1, 600, 0, 100, 100);
       }
       nw1.src = '../image/wN.png';

       imtab.push(nw1);
       
       var bw = new Image ();
       bw.onload = function ()
       {
			context.drawImage(bw, 200, 0, 100, 100);
       }
	   bw.src = '../image/wB.png';
       
       var bw1 = new Image ();
       bw.onload = function ()
       {
                        context.drawImage(bw1, 500, 0, 100, 100);
       }
	   bw1.src = '../image/wB.png';
       
       
       
	  var kw = new Image ();
	  kw.onload = function ()
		{
			context.drawImage (kw, 400, 0, 100, 100);
		}
	  kw.src = '../image/wK.png';
    
    var pw = new Image ();
    pw.onload = function ()
    {
        context.drawImage(pw, 0, 100, 100, 100);
    }
    pw.src = '../image/wP.png';
   
    var pw1 = new Image ();
    pw.onload = function ()
    {
        context.drawImage(pw1, 100, 100, 100, 100);
    }
    pw1.src = '../image/wP.png';
    
    var pw2 = new Image ();
    pw2.onload = function ()
    {
        context.drawImage(pw2, 200, 100, 100, 100);
    }
    pw2.src = '../image/wP.png';
    
    var pw3 = new Image ();
    pw3.onload = function ()
    {
        context.drawImage(pw3, 300, 100, 100, 100);
    }
    pw3.src = '../image/wP.png';
    
    var pw4 = new Image ();
    pw4.onload = function ()
    {
        context.drawImage(pw4, 400, 100, 100, 100);
    }
    pw4.src = '../image/wP.png';
    
    var pw5 = new Image ();
    pw5.onload = function ()
    {
        context.drawImage(pw5, 500, 100, 100, 100);
    }
    pw5.src = '../image/wP.png';
    
    var pw6 = new Image ();
    pw6.onload = function ()
    {
        context.drawImage(pw6, 600, 100, 100, 100);
    }
    pw6.src = '../image/wP.png';
   
   var pw7 = new Image ();
    pw7.onload = function ()
    {
        context.drawImage(pw7, 700, 100, 100, 100);
    }
    pw7.src = '../image/wP.png';
   
   
   
   
   
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
       
       var tb1 = new Image ();
       tb1.onload = function ()
       {
           context.drawImage(tb1, 700, 700, 100, 100);
       }
        tb1.src = '../image/bT.png';
        
       
        var nb =  new Image ();
        
       nb.onload = function () 
       {
           context.drawImage(nb, 100, 700, 100, 100);
       }
       nb.src = '../image/bN.png';


        var nb1 =  new Image ();
        
       nb1.onload = function () 
       {
           context.drawImage(nb1, 600, 700, 100, 100);
       }
       nb1.src = '../image/bN.png';

       var bb = new Image ();
       bb.onload = function ()
       {
			context.drawImage(bb, 200, 700, 100, 100);
       }
	   bb.src = '../image/bB.png';

       var bb1 = new Image ();
       bb1.onload = function ()
       {
                        context.drawImage(bb1, 500, 700, 100, 100);
       }
	   bb1.src = '../image/bB.png';


	  var kb = new Image ();
	  kw.onload = function ()
		{
			context.drawImage (kb, 400, 700, 100, 100);
		}
	  kb.src = '../image/nK.png';
    
    var pb = new Image ();
    pb.onload = function ()
    {
         context.drawImage(pb, 0, 600, 100, 100);
    }
    pb.src = '../image/nP.png';


    var pb1 = new Image ();
    pb1.onload = function ()
    {
         context.drawImage(pb1, 100, 600, 100, 100);
    }
    pb1.src = '../image/nP.png';


    var pb2 = new Image ();
    pb2.onload = function ()
    {
         context.drawImage(pb2, 200, 600, 100, 100);
    }
    pb2.src = '../image/nP.png';


    var pb3 = new Image ();
    pb3.onload = function ()
    {
         context.drawImage(pb3, 300, 600, 100, 100);
    }
    pb3.src = '../image/nP.png';


    var pb4 = new Image ();
    pb4.onload = function ()
    {
         context.drawImage(pb4, 400, 600, 100, 100);
    }
    pb.src = '../image/nP.png';


    var pb5 = new Image ();
    pb5.onload = function ()
    {
         context.drawImage(pb5, 500, 600, 100, 100);
    }
    pb5.src = '../image/nP.png';


    var pb6 = new Image ();
    pb6.onload = function ()
    {
         context.drawImage(pb6, 600, 600, 100, 100);
    }
    pb6.src = '../image/nP.png';


    var pb7 = new Image ();
    pb7.onload = function ()
    {
         context.drawImage(pb7, 700, 600, 100, 100);
    }
    pb7.src = '../image/nP.png';

    imtab.push(bw, bw1, kw, pw, pw1, pw2,pw3,pw4,pw5,pw6,pw7,qb,kb,tb,tb1,nb,nb1,bb,bb1,pb,pb1,pb2,pb3,pb4,pb5,pb6,pb7);
    
    ///Code AJAX pour interagir avec PHP
    function ajax (){
    var xhr = new XMLHttpRequest();
    var mx = (mouseX/100);
    var my = (mouseY/100 );
    
    xhr.onreadystatechange = function() { // On gère ici une requête asynchrone
        if (xhr.readyState == 4 && xhr.status == 200) {
           alert (xhr.responseText);
            var json = eval('('+xhr.responseText+')');
            alert (json);
            colorcase(json);
        }

    };
        xhr.open("GET", "http://chess.local/ajax.php?mx="+mx+"&my="+my, true);
    xhr.send(null);
    }
    
    
    function colorcase(tablo)
    {
        var i = 0;
        
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
   

