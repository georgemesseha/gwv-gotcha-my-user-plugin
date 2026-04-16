del J:\_batch.txt
echo select vdisk file="J:\VMs\Learning.vhdx" >> J:\_batch.txt
echo attach vdisk >> J:\_batch.txt
echo assign letter=F >> J:\_batch.txt
echo exit >> J:\_batch.txt
diskpart /s J:\_batch.txt
del J:\_batch.txt



