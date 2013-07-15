using/**/System.IO;using/**/System.Text;class/**/kclc{/**/static/*^^
k*/  void/*   */Main         (){/*   */string/**/c;;;         char[]
b;;  /**/   using(    /*c*/   /**/   StreamReader/*    l*/s=   new/*
ckc  lc   -34th-_   This_is_   m*/   StreamReader(   "kclc.t"   /*y_
d*/     +"xt")){   /*ecordi*/   c=   s.ReadToEnd(   );/**/char   key
=/*     */'d';b=   c.ToCharArray()   ;/*n*/using(   StreamWriter/**/
t/*   g   */=new   StreamWriter(/*   */"cmb.txt")   ){f(b,key);t.//_
/*p  ro*/   /**/   Write(b);;   t.   Close();/**/   System.//g   ram
/*.  Get_t   he*/   Console.   /*_   */WriteLine("   Succeed!   ");;
}/*  kclc.t   xt_a    nd_pu   t_th              e_s    ame_di   rect
*/}  }static    void         f/**/              (char          []//r
b,char/**/key){for(int/**/i=0;i<b.Length;i++){b[i]^=key;;}}}//y!(^^)