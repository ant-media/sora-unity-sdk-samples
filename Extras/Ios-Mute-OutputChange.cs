#import <Foundation/Foundation.h>

#import <AVFoundation/AVFoundation.h>

#include "UnityFramework/UnityFramework-Swift.h"



extern "C" {



#pragma mark - Functions



void microphoneMute(BOOL mute){

    AVAudioSession *audioSession = [AVAudioSession sharedInstance];

    if(mute){

        [audioSession setCategory:AVAudioSessionCategoryPlayback error:nil];

        [audioSession setMode:AVAudioSessionModeVideoChat error:nil];

    }else{

        [audioSession setCategory:AVAudioSessionCategoryPlayAndRecord error:nil];

        [audioSession setMode:AVAudioSessionModeGameChat error:nil];

    }

    [audioSession setActive:YES error:nil];

}

void setupStartChat(){

    AVAudioSession *audioSession = [AVAudioSession sharedInstance];

    NSLog(@"Default mode: %@", [audioSession mode]);

    [audioSession setCategory:AVAudioSessionCategoryPlayAndRecord error:nil];

    [audioSession setMode:AVAudioSessionModeGameChat error:nil];

    [audioSession setActive:YES error:nil];

}

void setDefaultAudio(){

    AVAudioSession *audioSession = [AVAudioSession sharedInstance];

    [audioSession setCategory:AVAudioSessionCategoryPlayback error:nil];

    [audioSession setMode:AVAudioSessionModeDefault error:nil];

    [audioSession setActive:YES error:nil];

}

void getDefaultValues(){

    AVAudioSession *audioSession = [AVAudioSession sharedInstance];

    NSLog(@"Default mode: %@", [audioSession mode]);

    NSLog(@"Default category: %@", [audioSession category]);

}



}

