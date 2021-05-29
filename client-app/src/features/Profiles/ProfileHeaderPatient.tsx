import { observer } from "mobx-react-lite";
import { Button, Card, Divider, Grid, Header, Icon, Item, Label, Reveal, Segment, Statistic } from "semantic-ui-react";
import { patientprofile } from "../../app/models/patientprofile";

interface Props {
    profile: patientprofile;
}

export default  observer (function ProfileHeaderPatient ({profile}: Props){
    return (
        <Segment>
            <Grid>
                <Grid.Column width={10}>
                    <Item.Group>
                    
                        <Item>
                            <Icon name='user' size='massive'></Icon>
                            
                            <Card
                                    href=''
                                    header={`${profile.name} ${profile.lastName}`}
                                    meta='Patient'
                                    description={`Profession: ${profile.profession}`}
                                />
                            <Item.Content verticalAlign='middle'>
                            </Item.Content>
                        </Item>
                    </Item.Group>
                </Grid.Column>
                <Grid.Column width={6}>
                <Item.Group divided>
                    <Item>

                    <Item.Content style={{marginTop:20}}>
                        <Item.Header as='a'>Address: {profile.address}</Item.Header>
                        <Item.Meta>
                        <span className='cinema'>Language: {profile.language}</span>
                        </Item.Meta>
                        <Item.Extra>
                        <Label icon='chevron right' content='Disease: Here is going to be the disease' />
                        </Item.Extra>
                    </Item.Content>
                    </Item>
                    </Item.Group>

                </Grid.Column>

                <Reveal animated="move" >
                    <Reveal.Content visible style={{width:' 100%'}}></Reveal.Content>
                    {/* <Button fluid color ='blue' content='Test' floated='right'/> */}
                </Reveal>

                
            </Grid>
        </Segment>
    )
})