﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    /**
     * ID       Explanation
     * ----     ------------------------------------------------
     * AENC     [[#sec4.20|Audio encryption]]
     * APIC     [#sec4.15 Attached picture]
     * COMM     [#sec4.11 Comments]
     * COMR     [#sec4.25 Commercial frame]
     * ENCR     [#sec4.26 Encryption method registration]
     * EQUA     [#sec4.13 Equalization]
     * ETCO     [#sec4.6 Event timing codes]
     * GEOB     [#sec4.16 General encapsulated object]
     * GRID     [#sec4.27 Group identification registration]
     * IPLS     [#sec4.4 Involved people list]
     * LINK     [#sec4.21 Linked information]
     * MCDI     [#sec4.5 Music CD identifier]
     * MLLT     [#sec4.7 MPEG location lookup table]
     * OWNE     [#sec4.24 Ownership frame]
     * PRIV     [#sec4.28 Private frame]
     * PCNT     [#sec4.17 Play counter]
     * POPM     [#sec4.18 Popularimeter]
     * POSS     [#sec4.22 Position synchronisation frame]
     * RBUF     [#sec4.19 Recommended buffer size]
     * RVAD     [#sec4.12 Relative volume adjustment]
     * RVRB     [#sec4.14 Reverb]
     * SYLT     [#sec4.10 Synchronized lyric/text]
     * SYTC     [#sec4.8 Synchronized tempo codes]
     * TALB     [#TALB Album/Movie/Show title]
     * TBPM     [#TBPM BPM (beats per minute)]
     * TCOM     [#TCOM Composer]
     * TCON     [#TCON Content type]
     * TCOP     [#TCOP Copyright message]
     * TDAT     [#TDAT Date]
     * TDLY     [#TDLY Playlist delay]
     * TENC     [#TENC Encoded by]
     * TEXT     [#TEXT Lyricist/Text writer]
     * TFLT     [#TFLT File type]
     * TIME     [#TIME Time]
     * TIT1     [#TIT1 Content group description]
     * TIT2     [#TIT2 Title/songname/content description]
     * TIT3     [#TIT3 Subtitle/Description refinement]
     * TKEY     [#TKEY Initial key]
     * TLAN     [#TLAN Language(s)]
     * TLEN     [#TLEN Length]
     * TMED     [#TMED Media type]
     * TOAL     [#TOAL Original album/movie/show title]
     * TOFN     [#TOFN Original filename]
     * TOLY     [#TOLY Original lyricist(s)/text writer(s)]
     * TOPE     [#TOPE Original artist(s)/performer(s)]
     * TORY     [#TORY Original release year]
     * TOWN     [#TOWN File owner/licensee]
     * TPE1     [#TPE1 Lead performer(s)/Soloist(s)]
     * TPE2     [#TPE2 Band/orchestra/accompaniment]
     * TPE3     [#TPE3 Conductor/performer refinement]
     * TPE4     [#TPE4 Interpreted, remixed, or otherwise modified by]
     * TPOS     [#TPOS Part of a set]
     * TPUB     [#TPUB Publisher]
     * TRCK     [#TRCK Track number/Position in set]
     * TRDA     [#TRDA Recording dates]
     * TRSN     [#TRSN Internet radio station name]
     * TRSO     [#TRSO Internet radio station owner]
     * TSIZ     [#TSIZ Size]
     * TSRC     [#TSRC ISRC (international standard recording code)]
     * TSSE     [#TSEE Software/Hardware and settings used for encoding]
     * TYER     [#TYER Year]
     * TXXX     [#TXXX User defined text information frame]
     * UFID     [#sec4.1 Unique file identifier]
     * USER     [#sec4.23 Terms of use]
     * USLT     [#sec4.9 Unsychronized lyric/text transcription]
     * WCOM     [#WCOM Commercial information]
     * WCOP     [#WCOP Copyright/Legal information]
     * WOAF     [#WOAF Official audio file webpage]
     * WOAR     [#WOAR Official artist/performer webpage]
     * WOAS     [#WOAS Official audio source webpage]
     * WORS     [#WORS Official internet radio station homepage]
     * WPAY     [#WPAY Payment]
     * WPUB     [#WPUB Publishers official webpage]
     * WXXX     [#WXXX User defined URL link frame]
     */

    public class ID3Frame
    {
        private readonly Dictionary<string, string> LongIDs = new Dictionary<string, string>()
        {
            { "AENC", "Audio encryption" },
            { "APIC", "Attached picture" },
            { "COMM", "Comments" },
            { "COMR", "Commercial frame" },
            { "ENCR", "Encryption method registration" },
            { "EQUA", "Equalization" },
            { "ETCO", "Event timing codes" },
            { "GEOB", "General encapsulated object" },
            { "GRID", "Group identification registration" },
            { "IPLS", "Involved people list" },
            { "LINK", "Linked information" },
            { "MCDI", "Music CD identifier" },
            { "MLLT", "MPEG location lookup table" },
            { "OWNE", "Ownership frame" },
            { "PRIV", "Private frame" },
            { "PCNT", "Play counter" },
            { "POPM", "Popularimeter" },
            { "POSS", "Position synchronisation frame" },
            { "RBUF", "Recommended buffer size" },
            { "RVAD", "Relative volume adjustment" },
            { "RVRB", "Reverb" },
            { "SYLT", "Synchronized lyric/text" },
            { "SYTC", "Synchronized tempo codes" },
            { "TALB", "Album/Movie/Show title" },
            { "TBPM", "BPM (beats per minute)" },
            { "TCOM", "Composer" },
            { "TCON", "Content type" },
            { "TCOP", "Copyright message" },
            { "TDAT", "Date" },
            { "TDLY", "Playlist delay" },
            { "TENC", "Encoded by" },
            { "TEXT", "Lyricist/Text writer" },
            { "TFLT", "File type" },
            { "TIME", "Time" },
            { "TIT1", "Content group description" },
            { "TIT2", "Title/songname/content description" },
            { "TIT3", "Subtitle/Description refinement" },
            { "TKEY", "Initial key" },
            { "TLAN", "Language(s)" },
            { "TLEN", "Length" },
            { "TMED", "Media type" },
            { "TOAL", "Original album/movie/show title" },
            { "TOFN", "Original filename" },
            { "TOLY", "Original lyricists(s)/text writer(s)" },
            { "TOPE", "Original artist(s)/performer(s)" },
            { "TORY", "Original release year" },
            { "TOWN", "File owner/licensee" },
            { "TPE1", "Lead performer(s)/Soloist(s)" },
            { "TPE2", "Band/orchestra/accompaniment" },
            { "TPE3", "Conductor/performer refinement" },
            { "TPE4", "Interpreted, remixed or otherwise modified by" },
            { "TPOS", "Part of a set" },
            { "TPUB", "Publisher" },
            { "TRCK", "Track number/Position in set" },
            { "TRDA", "Recording dates" },
            { "TRSN", "Internet radio station name" },
            { "TRSO", "Internet radio station owner" },
            { "TSIZ", "Size" },
            { "TSRC", "ISRC (International standard recording code)" },
            { "TSSE", "Software/Hardware and settings used for encoding" },
            { "TYER", "Year" },
            { "UFID", "Unique file identifier" },
            { "USER", "Terms of use" },
            { "USLT", "Unsynchronized lyric/text transcription" },
            { "WCOM", "Commercial information" },
            { "WCOP", "Copyright/Legal information" },
            { "WOAF", "Official audio file webpage" },
            { "WOAR", "Official artist/performer webpage" },
            { "WOAS", "Official audio source webpage" },
            { "WORS", "Official internet radio station homepage" },
            { "WPAY", "Payment" },
            { "WPUB", "Publishers official webpage" },
        };

        // Fields
        private int _offset;
        private string _id;
        private string _longID;
        private int _size;
        private byte[] _flags;
        private byte[] _data;
        
        // byte offset
        public int Offset { get; set; }

        public string ID {
            get
            {
                return _id;
            }
            set {
                // Set field value
                _id = value;
                if (LongIDs.ContainsKey(value)) _longID = LongIDs[value];
            }
        }

        public string LongID {
            get {
                return _longID;
            }
        }

        // frame size - header size = frame size - 10
        public int Size { get; set; }
        public byte[] Flags { get; set; }

        public byte[] Data {
            set {
                _data = new byte[value.Length];
                _data = value;
            }
        }

        public string GetDataString()
        {
            if(_data[0] == 0x00)
            {
                // ISO-8859-1 text encoding
                Console.WriteLine();
                Console.WriteLine($"DEBUG (ID3Frame.cs) ISO-8859-1 encoding");

                // var for our data string
                var stringChars = new char[_data.Length - 1];

                // Iterate our _data byte array
                int i = 0;
                while(i < stringChars.Length)
                {
                    // Check for zero bytes
                    if (_data[i + 1] != 0x00)
                    {
                        stringChars[i] = (char)_data[i + 1]; 
                    } else
                    {
                        // Change zero byte to space for the moment
                        stringChars[i] = ' ';
                    }

                    i++;
                }

                // Return the string
                return new string(stringChars);
                
            }
            else if (_data[0] == 0x01)
            {
                // Unicode text encoding
                Console.WriteLine();
                Console.WriteLine($"DEBUG (ID3Frame.cs) Unicode encoding");

                // var for our data string
                var stringChars = new char[_data.Length - 1];

                // Iterate our _data byte array
                int i = 0;
                while (i < stringChars.Length)
                {
                    // Check for zero bytes
                    if (_data[i + 1] != 0x00)
                    {
                        stringChars[i] = (char)_data[i + 1];
                    }
                    else
                    {
                        // Change zero byte to space for the moment
                        stringChars[i] = ' ';
                    }

                    i++;
                }

                // Return the string
                return new string(stringChars);
            } else
            {
                // Encoding not specified
                Console.WriteLine();
                Console.WriteLine($"DEBUG (ID3Frame.cs) Text encoding not specified.");

                // var for our data string
                var stringChars = new char[_data.Length];

                // Iterate our _data byte array
                int i = 0;
                while (i < stringChars.Length)
                {
                    // Check for zero bytes
                    if (_data[i] != 0x00)
                    {
                        stringChars[i] = (char)_data[i];
                    }
                    else
                    {
                        // Change zero byte to space for the moment
                        stringChars[i] = ' ';
                    }

                    i++;
                }

                // Return the string
                return new string(stringChars);
            }
        }

        public void PrintDataBytes()
        {
            foreach(byte b in _data)
            {
                Console.Write($"{b:X2} ");
            }

            Console.WriteLine();
        } 

        public override string ToString()
        {
            string d = GetDataString();

            return $"{ID} {d}";
        }
    }
}
