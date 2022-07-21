#!/bin/bash
echo "Downloading zip"
wget https://github.com/shourgamer2/TermBolt/releases/download/3.0.0/TermBolt-Linux.zip
echo "Installing unzip"
sudo apt-get install unzip
echo "Unzipping"
unzip TermBolt-Linux.zip
echo "Everything is done now run ./termbolt to open termbolt!"
