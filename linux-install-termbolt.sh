#!/bin/bash
echo "Installing wget"
sudo apt-get install wget
echo "Downloading zip"
wget https://github.com/shourgamer2/TermBolt/releases/download/3.0.0/TermBolt-Linux.zip
echo "Installing unzip"
sudo apt-get install unzip
echo "Unzipping"
unzip TermBolt-Linux.zip
echo "Some stuff to make it work!"
export DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1
chmod u+x ./termbolt
echo "Everything is done now run ./termbolt to open termbolt!"
