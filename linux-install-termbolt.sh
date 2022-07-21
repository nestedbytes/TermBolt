#!/bin/bash
echo "Downloading zip"
wget https://github.com/shourgamer2/TermBolt/releases/download/3.0.0/TermBolt-Linux.zip
echo "Installing unzip"
sudo apt-get install unzip
echo "Unzipping"
unzip TermBolt-Linux.zip
echo "Some stuff to make it work!"
export DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1
echo "Everything is done now run chmod u+x ./termbolt and then  ./termbolt to open termbolt!"
