#include<reg52.h>
#include<stdio.h>

unsigned char i=0;
unsigned char buf[7]={0x00,0xc0,0xc0,0xc0,0xc0,0xc0,0xc0};
unsigned char ding[]={0,1,0,1,0,1,0,1,0,1};
unsigned char len=1;
unsigned char num=1;
sbit EN=P3^3;
void init()
{
	TMOD=0x20;
	TH1=0xf3;
	TR1=1;
	SCON=0x50;
	PCON=0x80;
	EA=1;
	ES=1;
}

void delay(unsigned char z)
{
	unsigned char x,y;
	for(x=z;x>0;x--)
		for(y=255;y>0;y--);
}
void display()
{
	if(buf[0]==0xaa)
	{						  
		unsigned char p;
		for(p=1;p<7;p++)
		{
			P2=~(num<<(p-1));
			P0=buf[p];
			delay(1);
			P0=0xff;
		}
	}
	if(buf[0]==0x55)
	{
		P2=~(num<<7);
		P0=~buf[1];
	}
    if(buf[0]==0x5a)
    {
        if(buf[1]==0x01)
        {
            EN=!EN;
            delay(255);
        }
    }
}
int main()
{
	init();
	while(1)
	{
		display();
	}
}

void recv() interrupt 4
{
	if(RI)
	{
		buf[i]=SBUF;
		if(i==0)
		{
			if(buf[i]==0xaa)
				len=6;
			else
				len=1;
		}
		if(len==1&&i==1)
		{
			if(buf[0]==0xa5)
				P2=~buf[1];
		}
		if(i==len)
			i=0;
		else
			i++;
		RI=0;		
	}
}